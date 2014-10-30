using System;
using System.Xml.Linq;
using SG.Learning.DevelopingChinese.Properties;

namespace SG.Learning.DevelopingChinese
{
    public class FlashcardList
    {
        private readonly FlashcardCategoryTree _categories;
        private readonly string _creator;

        public FlashcardList(XElement root)
        {
            _categories = new FlashcardCategoryTree(root.Element("categories"));

            var cardRoot = root.Element("cards");
            if (cardRoot == null)
                throw new ArgumentException(Resources.FlashcardList_FlashcardList_Missing_cards_from_Flashcard_XML_file, "root");

            _creator = root.Attribute("creator").Value;
        }

        public string Creator
        {
            get { return _creator; }
        }

        public FlashcardCategoryTree Categories
        {
            get { return _categories; }
        }
    }
}