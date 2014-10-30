using System.IO;
using System.Threading.Tasks;

namespace SG.Learning.DevelopingChinese
{
    public class FlashcardFile : DataFile<FlashcardStore>
    {
        public FlashcardFile(FileInfo dataFile) : base(dataFile)
        {
        }

        protected override async Task<FlashcardStore> ParseDataFileImplAsync()
        {
            return await Task.Run(() => ParseFlashcardXmlFile());
        }

        private FlashcardStore ParseFlashcardXmlFile()
        {
            return ParseXmlFileSharedRead(FlashcardStore.LoadFromXml);
        }

        public static FlashcardFile Parse(FileInfo plecoFlashcards)
        {
            // TODO: This is only a temporary measure
            var fcf = new FlashcardFile(plecoFlashcards);
            fcf.ParseFlashcardXmlFile();
            return fcf;
        }
    }
}