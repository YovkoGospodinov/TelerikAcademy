using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace _14.ApplyTheXSLT
{
    public class StartUp
    {
        public static void Main()
        {
            XDocument xDoc = XDocument.Load("../../../UsedFiles/catalog.xml");

            XDocument transformedDoc = new XDocument();
            using (XmlWriter writer = transformedDoc.CreateWriter())
            {
                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load(XmlReader.Create(new StreamReader("../../../13CreateXSLStylesheet.xslt")));
                transform.Transform(xDoc.CreateReader(), writer);
            }

            transformedDoc.Save("../../../UsedFiles/transformed-catalog.html");
        }
    }
}
