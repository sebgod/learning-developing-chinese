using System;
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

        public IEnumerable<DataFile<T>> EnumerateDataFiles<T>(Func<FileInfo, DataFile<T>> dataFileParser)
            where T : class
        {
            return EnumerateXmlFiles().Select(dataFileParser);
        }

        private IEnumerable<FileInfo> EnumerateXmlFiles()
        {
            return _directory.EnumerateFiles("*.xml");
        }
    }
}
