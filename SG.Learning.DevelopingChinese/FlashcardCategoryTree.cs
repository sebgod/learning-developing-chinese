using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using SG.Learning.DevelopingChinese.Properties;

namespace SG.Learning.DevelopingChinese
{
    public class FlashcardCategoryTree
    {
        private readonly HashSet<string> _categorySet;
        private readonly List<string> _categoryList;

        public FlashcardCategoryTree(XContainer catRoot)
        {
            if (catRoot == null)
            {
                throw new ArgumentException(
                    Resources.FlashcardCategoryTree_FlashcardCategoryTree_The_flashcard_list_contains_no_categories,
                    "catRoot");
            }
            _categoryList = catRoot.Elements("category").Select(pCat => pCat.Attribute("name").Value).ToList();
            _categorySet = new HashSet<string>(_categoryList);
        }

        public bool ContainsCategory(params string[] subCategories)
        {
            if (subCategories.Length == 0)
                throw new ArgumentException(
                    Resources.FlashcardCategoryTree_ContainsCategory_Please_specify_at_least_one_category,
                    "subCategories");

            return _categorySet.Contains(string.Join("/", subCategories));
        }
    }
}