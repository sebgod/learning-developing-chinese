using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SG.Learning.DevelopingChinese
{
    public class UnitFile : DataFile<Unit>
    {
        public UnitFile(FileInfo unitFile)
            : base(unitFile)
        {
        }

        protected override async Task<Unit> ParseDataFile()
        {
            return await Task.Run(() =>
                {
                    using (var textStream = DataFileInfo.OpenText())
                    {
                        return new Unit(XDocument.Load(textStream, LoadOptions.PreserveWhitespace));
                    }
                });
        }

        public static UnitFile Parse(FileInfo unitFile)
        {
            return new UnitFile(unitFile);
        }
    }
}