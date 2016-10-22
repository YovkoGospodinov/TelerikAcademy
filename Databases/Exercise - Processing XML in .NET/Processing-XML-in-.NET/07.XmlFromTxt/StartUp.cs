using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace _07.XmlFromTxt
{
    public class StartUp
    {
        public static void Main()
        {
            string path = "../../../UsedFiles/PersonInfo.txt";
            string newPath = "../../../UsedFiles/CreatedPersonInfo.xml";
            List<Person> people = new List<Person>();

            string[] lines = File.ReadAllLines(path);
            
            string name = lines[0];
            string address = lines[1];
            string phoneNumber = lines[2];

            var person = new Person
            {
                Name = name,
                Address = address,
                PhoneNumber = phoneNumber
            };

            people.Add(person);

            WriteToXML(newPath, people);
        }

        private static void WriteToXML(string newPath, IList<Person> people)
        {
            using (FileStream fileStream = new FileStream(newPath, FileMode.Create))
            {
                new XmlSerializer(typeof(List<Person>)).Serialize(fileStream, people);
            }
        }
    }
}
