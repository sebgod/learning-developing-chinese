using System.Collections.Generic;
using System.Xml.Linq;

namespace SG.Learning.DevelopingChinese
{
    public static class XmlHelper
    {
        public static readonly XNamespace SpreadsheetNS = "urn:schemas-microsoft-com:office:spreadsheet";
    
        public static IEnumerable<XElement> SpreadsheetElements(this XElement @this, string localName)
        {
            return @this.Elements(SpreadsheetNS + localName);
        }

        public static XElement SpreadsheetElement(this XElement @this, string localName)
        {
            return @this.Element(SpreadsheetNS + localName);
        }

        public static IEnumerable<XAttribute> SpreadsheetAttributes(this XElement @this, string localName)
        {
            return @this.Attributes(SpreadsheetNS + localName);
        }

        public static XAttribute SpreadsheetAttribute(this XElement @this, string localName)
        {
            return @this.Attribute(SpreadsheetNS + localName);
        }

        public static int AsInteger(this XAttribute @this)
        {
            return int.Parse(@this.Value);
        }
    }
}