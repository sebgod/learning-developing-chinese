using System.IO;
using System.Threading.Tasks;

namespace SG.Learning.DevelopingChinese
{
    public abstract class DataFile<T>
        where T : class
    {
        private T _parsedFileCache;
        private readonly FileInfo _dataFile;

        protected DataFile(FileInfo dataFile)
        {
            _dataFile = dataFile;
        }

        internal FileInfo DataFileInfo
        {
            get { return _dataFile; }
        }

        public string Name
        {
            get { return Path.GetFileNameWithoutExtension(_dataFile.Name); }
        }

        public async Task<T> UnitAsync()
        {
            return _parsedFileCache ?? (_parsedFileCache = await ParseDataFile());
        }

        protected abstract Task<T> ParseDataFile();

        private string _uniqueString;

        public override string ToString()
        {
            return _uniqueString ?? (_uniqueString = _dataFile.FullName);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return !ReferenceEquals(obj, null) && (obj is DataFile<T>) && (ToString() == obj.ToString());
        }
    }
}