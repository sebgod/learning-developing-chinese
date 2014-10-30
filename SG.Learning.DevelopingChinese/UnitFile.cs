using System;
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

        protected override async Task<Unit> ParseDataFileImplAsync()
        {
            return await Task.Run(() => ParseXmlFileSharedRead(Unit.LoadFromXml));
        }
        
        public static UnitFile Parse(FileInfo unitFile)
        {
            return new UnitFile(unitFile);
        }
    }
}