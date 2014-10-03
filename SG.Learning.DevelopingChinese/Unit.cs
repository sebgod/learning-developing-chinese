using System.Xml.Linq;

namespace SG.Learning.DevelopingChinese
{
    public class Unit : XmlBasedDataBase
    {
        private readonly Vocabulary _vocabulary;

        public Unit(XDocument spreadsheetML)
            : base(spreadsheetML)
        {
            var root = XmlDocument.Root;
            if (root == null || !root.HasElements) return;

            var worksheets = root.SpreadsheetElements("Worksheet");
            foreach (var worksheet in worksheets)
            {
                switch (worksheet.SpreadsheetAttribute("Name").Value.ToLowerInvariant())
                {
                    case "vocabulary":
                        _vocabulary = new Vocabulary(worksheet);
                        break;
                    
                    case "text":
                        // ParseText(worksheet);
                        break;

                    case "proper":
                        // ParseProperNouns(worksheet);
                        break;
                }
            }
        }

        public Vocabulary Vocabulary { get { return _vocabulary; } }

        public static Unit LoadFromXml(XDocument spreadsheetML)
        {
            return new Unit(spreadsheetML);
        }
    }
}