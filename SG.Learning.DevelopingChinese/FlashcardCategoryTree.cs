using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using SG.Learning.DevelopingChinese.Properties;

namespace SG.Learning.DevelopingChinese
{
    public class FlashcardCategoryTree
    {
        private readonly XContainer _categoryRoot;
        private readonly Dictionary<string, XElement> _categoryMap;
        private readonly List<string> _categoryList;

        public FlashcardCategoryTree(XContainer categoryRoot)
        {
            if (categoryRoot == null)
            {
                throw new ArgumentException(
                    Resources.FlashcardCategoryTree_FlashcardCategoryTree_The_flashcard_list_contains_no_categories,
                    "categoryRoot");
            }
            _categoryRoot = categoryRoot;
            var categoryElements = categoryRoot.Elements("category").ToList();
            Func<XElement, string> keySelector = pCat => pCat.Attribute("name").Value;
            _categoryList = categoryElements.Select(keySelector).ToList();
            _categoryMap = categoryElements.ToDictionary(keySelector);
        }

        public bool Add(params string[] subCategories)
        {
            var catFQN = JoinSubCategories(subCategories);
            var alreadyInSet = _categoryMap.ContainsKey(catFQN);
            if (!alreadyInSet)
            {
                _categoryList.Add(catFQN);
                var catNode = new XElement("category");
                catNode.SetAttributeValue("name", catFQN);
                _categoryRoot.Add(catNode);
                _categoryMap[catFQN] = catNode;
                return true;
            }
            return false;
        }

        public bool ContainsCategory(params string[] subCategories)
        {
            if (subCategories.Length == 0)
                throw new ArgumentException(
                    Resources.FlashcardCategoryTree_ContainsCategory_Please_specify_at_least_one_category,
                    "subCategories");

            return _categoryMap.ContainsKey(JoinSubCategories(subCategories));
        }

        private static string JoinSubCategories(string[] subCategories)
        {
            return string.Join("/", subCategories);
        }
    }
}