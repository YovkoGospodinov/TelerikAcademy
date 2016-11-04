using System;
using System.Linq;
using NorthWind.Data.Data;

namespace ExtendedEmployee
{
    public class StartUp
    {
        public static void Main()
        {
            // The employee is extended in NorthWind.Data.Data

            using (var context = new NorthwindEntities())
            {
                var employee = context.Employees.FirstOrDefault();

                Console.WriteLine($"Employee {employee.FirstName} categories:");

                foreach (var territory in employee.TerritoriesSet)
                {
                    Console.WriteLine(territory.TerritoryDescription);
                }
            }
        }
    }
}
