using System.IO;
using System.Threading.Tasks;

namespace SG.Learning.DevelopingChinese
{
    public class FlashcardFile : DataFile<FlashcardStore>
    {
        public FlashcardFile(FileInfo dataFile) : base(dataFile)
        {
        }

        protected override async Task<FlashcardStore> ParseDataFile()
        {
            return await Task.Run(() => ParseXmlFileSharedRead(FlashcardStore.LoadFromXml));
        }

        public static FlashcardFile Parse(FileInfo plecoFlashcards)
        {
            return new FlashcardFile(plecoFlashcards);
        }
    }
}