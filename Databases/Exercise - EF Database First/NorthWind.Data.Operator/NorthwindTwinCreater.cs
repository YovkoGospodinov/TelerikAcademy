using NorthWind.Data.Data;

namespace NorthWind.Data.Operator
{
    public class NorthwindTwinCreater
    {
        public NorthwindTwinCreater()
        {
            var ctx = new NorthwindEntities();

            ctx.Database.CreateIfNotExists();
        }
    }
}
