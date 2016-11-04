using NorthWind.Data.Data;

namespace NorthwindTwin
{
    public class StartUp
    {
        static void Main()
        {
            var ctx = new NorthwindEntities();

            ctx.Database.CreateIfNotExists();
        }
    }
}
