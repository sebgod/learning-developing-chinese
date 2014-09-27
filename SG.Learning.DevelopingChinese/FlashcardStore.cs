using System.Xml.Linq;

namespace SG.Learning.DevelopingChinese
{
    public class FlashcardStore : XmlBasedDataBase
    {
        public FlashcardStore(XDocument plecoFlashcards) : base(plecoFlashcards)
        {

        }
    }
}