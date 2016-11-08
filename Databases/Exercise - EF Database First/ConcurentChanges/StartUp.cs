using System.Linq;
using NorthWind.Data.Data;

namespace ConcurentChanges
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Second context will override the first one. We can use transactions.
            var firstCtx = new NorthwindEntities();

            firstCtx.Customers.FirstOrDefault().CompanyName = "WayneCarCorp";

            var secondCtx = new NorthwindEntities();

            secondCtx.Customers.FirstOrDefault().CompanyName = "Lakula JSC";
            
            firstCtx.SaveChanges();
            secondCtx.SaveChanges();
        }
    }
}
