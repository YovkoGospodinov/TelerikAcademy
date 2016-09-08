namespace Bunnies
{
    using System.Collections.Generic;
    using System.IO;
    using Bunnies.Enums;
    using Bunnies.Factory;
    using Bunnies.Models;

    public class StartUp
    {
        private const string BunniesFilePath = @"..\..\bunnies.txt";

        public static void Main()
        {
            IList<Bunny> listOfBunnies = GetListOfBunnies();

            var bunniesFactory = new BunniesFactory(listOfBunnies);
            
            var consoleWriter = new ConsoleWriter();
            foreach (var bunny in bunniesFactory.Bunnies)
            {
                bunny.Introduce(consoleWriter);
            }
            
            var fileStream = File.Create(BunniesFilePath);
            fileStream.Close();
            
            var streamWriter = new StreamWriter(BunniesFilePath);
            foreach (var bunny in bunniesFactory.Bunnies)
            {
                streamWriter.WriteLine(bunny.ToString());
            }
        }

        public static IList<Bunny> GetListOfBunnies()
        {
            IList<Bunny> listOfBunnies = new List<Bunny>
            {
                new Bunny
                {
                    Name = "Leonid",
                    Age = 1,
                    FurType = FurType.NotFluffy
                },
                new Bunny
                {
                    Name = "Rasputin",
                    Age = 2,
                    FurType = FurType.ALittleFluffy
                },
                new Bunny
                {
                    Name = "Tiberii",
                    Age = 3,
                    FurType = FurType.ALittleFluffy
                },
                new Bunny
                {
                    Name = "Neron",
                    Age = 1,
                    FurType = FurType.ALittleFluffy
                },
                new Bunny
                {
                    Name = "Klavdii",
                    Age = 3,
                    FurType = FurType.Fluffy
                },
                new Bunny
                {
                    Name = "Vespasian",
                    Age = 3,
                    FurType = FurType.Fluffy
                },
                new Bunny
                {
                    Name = "Domician",
                    Age = 4,
                    FurType = FurType.FluffyToTheLimit
                },
                new Bunny
                {
                    Name = "Tit",
                    Age = 2,
                    FurType = FurType.FluffyToTheLimit
                }
            };

            return listOfBunnies;
        }
    }
}
