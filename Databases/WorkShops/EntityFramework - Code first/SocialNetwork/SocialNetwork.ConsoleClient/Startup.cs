using System;
using System.Data.Entity;
using System.Linq;
using SocialNetwork.Data;
using SocialNetwork.Data.Migrations;

namespace SocialNetwork.ConsoleClient
{
    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SocialNetworkContext, Configuration>());
            using (var ctx = new SocialNetworkContext())
            {
                Console.WriteLine(ctx.Images.Count());
            }


        }
    }
}
