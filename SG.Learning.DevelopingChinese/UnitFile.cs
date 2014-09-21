using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SG.Learning.DevelopingChinese
{
    public class UnitFile
    {
        private readonly DataFolder _folder;
        private readonly FileInfo _unitFile;

        public UnitFile(DataFolder folder, FileInfo unitFile)
        {
            _folder = folder;
            _unitFile = unitFile;
        }

        public string Name
        {
            get { return Path.GetFileNameWithoutExtension(_unitFile.Name); }
        }

        private Unit _unit;
        public async Task<Unit> UnitAsync()
        {
            return _unit ?? (_unit = await ParseXmlFileAsync());
        }

        private async Task<Unit> ParseXmlFileAsync()
        {
            return await Task.Run(() =>
                {
                    using (var textStream = _unitFile.OpenText())
                    {
                        return new Unit(XDocument.Load(textStream, LoadOptions.PreserveWhitespace));
                    }
                });
        }

        private string _uniqueString;

        public override string ToString()
        {
            return _uniqueString ?? (_uniqueString = _folder.ToString() + Path.AltDirectorySeparatorChar + Name);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return !ReferenceEquals(obj, null) && (obj is UnitFile) && (ToString() == obj.ToString());
        }
    }
}