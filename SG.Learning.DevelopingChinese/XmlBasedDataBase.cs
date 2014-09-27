using System.Xml.Linq;

namespace SG.Learning.DevelopingChinese
{
    public abstract class XmlBasedDataBase
    {
        internal readonly XDocument XmlDocument;

        internal XmlBasedDataBase(XDocument xmlDocument)
        {
            XmlDocument = xmlDocument;
        }
    }
}