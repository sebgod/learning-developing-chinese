using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SG.Learning.DevelopingChinese
{
    public class DataFolder
    {
        private readonly DirectoryInfo _directory;

        public DataFolder(DirectoryInfo directory)
        {
            _directory = directory;
        }

        public string Name { get { return _directory.Name; } }

        public IEnumerable<UnitFile> EnumerateUnits()
        {
            return _directory.EnumerateFiles("*.xml").Select(unitFile => new UnitFile(this, unitFile));
        }
    }
}
