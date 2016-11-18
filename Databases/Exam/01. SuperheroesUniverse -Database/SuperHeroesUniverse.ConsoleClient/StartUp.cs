using System.Data.Entity;
using SuperHeroesUniverse.Data;
using SuperHeroesUniverse.Data.Migrations;
using System;
using System.Linq;
using DataManipulator;

namespace SuperHeroesUniverse.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SuperHeroesUniverseDBContext, Configuration>());

            //using (var ctx = new SuperHeroesUniverseDBContext())
            //{
            //    Console.WriteLine(ctx.Superheroes.Count());
            //}

            var jsonImporter = new JSonSuperheroesImporter();
            jsonImporter.Import();
        }
    }
}
