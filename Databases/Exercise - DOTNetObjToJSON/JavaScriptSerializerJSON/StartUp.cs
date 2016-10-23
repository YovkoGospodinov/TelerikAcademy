using System;
using System.Web.Script.Serialization;

namespace JavaScriptSerializerJSON
{
    public class StartUp
    {
        public static void Main()
        {
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

            var serializer = new JavaScriptSerializer();

            var json = serializer.Serialize(person);

            Console.WriteLine(json);
        }
    }
}
