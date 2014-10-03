using System.Xml.Linq;

namespace SG.Learning.DevelopingChinese
{
    public class FlashcardList
    {
        private readonly string _creator;

        public FlashcardList(XElement root)
        {
            var catRoot = root.Element("categories");
            var cardRoot = root.Element("cards");
            _creator = root.Attribute("creator").Value;
        }

        public string Creator
        {
            get { return _creator; }
        }
    }
}