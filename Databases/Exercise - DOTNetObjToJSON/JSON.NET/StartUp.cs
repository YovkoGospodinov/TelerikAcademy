using System;
using Newtonsoft.Json;
using System.IO;

namespace JSON.NET
{
    public class StartUp
    {
        public static void Main()
        {
            string path = "../../../usedfiles/person.json";

            var person = new Person
            {
                Name = "Ivan Ivanov",
                Gender = "Male",
                PhoneNumber = "0987654321",
                Employer = new Employer
                {
                    Id = "1234212",
                    Name = "Minev OOD"
                }
            };

            WriteToFile(person, path);

            var loadedPerson = LoadFromFile(path);

            Console.WriteLine($"{loadedPerson.Name} - {loadedPerson.Employer.Name} - {loadedPerson.PhoneNumber}");
        }

        private static Person LoadFromFile(string path)
        {
            var json = File.ReadAllText(path);

            var person = JsonConvert.DeserializeObject<Person>(json);

            return person;
        }

        private static void WriteToFile(Person person, string path)
        {
            var json = JsonConvert.SerializeObject(person, Formatting.Indented);

            File.WriteAllText(path, json);
        }
    }
}
