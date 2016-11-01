using System;
using System.Data.Entity;
using System.Linq;
using StudentSystem.Data;
using StudentSystem.Data.Migrations;

namespace StudentSystem.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemEntities, Configuration>());
            using (var ctx = new StudentSystemEntities())
            {
                Console.WriteLine(ctx.Courses.Count());
            }
        }
    }
}
