using System.Xml.Linq;

namespace SG.Learning.DevelopingChinese
{
    public class FlashcardStore : XmlBasedDataBase
    {
        private readonly FlashcardList _flashcardList;

        public FlashcardStore(XDocument plecoFlashcards) : base(plecoFlashcards)
        {
            var root = XmlDocument.Root;
            if (root == null || !root.HasElements) return;
        
            _flashcardList = new FlashcardList(root);
        }

        public FlashcardList Flashcards
        {
            get { return _flashcardList; }
        }

        public static FlashcardStore LoadFromXml(XDocument plecoFlashcards)
        {
            return new FlashcardStore(plecoFlashcards);
        }
    }
}