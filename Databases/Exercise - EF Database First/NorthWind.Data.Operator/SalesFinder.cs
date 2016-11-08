using System.Collections.Generic;
using System.Linq;
using NorthWind.Data.Data;
using NorthWind.Data.Interfaces;
using System;

namespace NorthWind.Data.Operator
{
    public class SalesFinder
    {
        private INorthwindEntities database;
        
        public SalesFinder(INorthwindEntities db)
        {
            this.database = db;
        }

        public IEnumerable<Order> GetOrdersBySpecifiedParameters(string region, DateTime startDate, DateTime endDate)
        {
            var orders = database.Orders.Where(o => o.ShipRegion == region && o.OrderDate >= startDate && o.OrderDate <= endDate).ToList();

            return orders;
        }
    }
}
