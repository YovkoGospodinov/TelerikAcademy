namespace Task2.Person.Maker
{
    using Task2.Person.Maker.Enums;
    using Task2.Person.Maker.Models;

    public class StartUp
    {
        public static void Main()
        {
        }

        public void CreatePerson(int personAge)
        {
            var newPerson = new Person();

            newPerson.Age = personAge;

            bool isPersonAgeEven = personAge % 2 == 0;

            if (isPersonAgeEven)
            {
                newPerson.Gender = Gender.Man;
                newPerson.Name = "Tough Guy";
            }
            else
            {
                newPerson.Gender = Gender.Woman;
                newPerson.Name = "Hot Chock";
            }
        }
    }
}
