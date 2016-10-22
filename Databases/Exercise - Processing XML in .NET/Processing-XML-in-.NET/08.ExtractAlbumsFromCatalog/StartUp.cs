using System.Xml;

namespace _08.ExtractAlbumsFromCatalog
{
    public class StartUp
    {
        public static void Main()
        {
            string readingPath = "../../../UsedFiles/catalog.xml";
            string writingPath = "../../../UsedFiles/albums.xml";

            XmlReader reader = XmlReader.Create(readingPath);

            XmlWriter writer = XmlWriter.Create(writingPath);

            using (writer)
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                using (reader)
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "name")
                            {
                                writer.WriteStartElement("album");
                                writer.WriteElementString("name", reader.ReadElementString());
                            }
                            else if (reader.Name == "artist")
                            {
                                writer.WriteElementString("artist", reader.ReadElementString());
                                writer.WriteEndElement();
                            }
                        }
                    }
                }

                writer.WriteEndDocument();
            }
        }
    }
}
