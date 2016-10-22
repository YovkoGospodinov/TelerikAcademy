using System;
using System.IO;
using System.Xml;

namespace _09.TraverseDirectory
{
    public class StartUp
    {
        public static void Main()
        {
            var writer = XmlWriter.Create("../../../UsedFiles/directories.xml", new XmlWriterSettings() { Indent = true, NewLineChars = Environment.NewLine });
            string path = "../../../../";

            using (writer)
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("dirs");
                writer.WriteAttributeString("name", path);
                GetAllFilesAndFoldersRecursively(
                    new DirectoryInfo(path), writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private static void GetAllFilesAndFoldersRecursively(DirectoryInfo path, XmlWriter writer)
        {
            writer.WriteStartElement("dir");
            writer.WriteAttributeString("name", path.Name);

            try
            {
                writer.WriteStartElement("files");
                foreach (FileInfo file in path.GetFiles())
                {
                    writer.WriteStartElement("file");
                    writer.WriteElementString("name", file.Name);
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }
            catch (IOException)
            {
                Console.WriteLine("Directory {0}  \n could not be accessed!", path.FullName);
                return;
            }
            
            foreach (DirectoryInfo dir in path.GetDirectories())
            {
                path = dir;
                GetAllFilesAndFoldersRecursively(dir, writer);
            }

            writer.WriteEndElement();
        }
    }
}