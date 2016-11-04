using System.Collections.Generic;
using System.Linq;
using NorthWind.Data.Data;
using NorthWind.Data.Interfaces;

namespace NorthWind.Data.Operator
{
    public class CustomersFinder
    {
        private INorthwindEntities database;

        public CustomersFinder(INorthwindEntities db)
        {
            this.database = db;
        }

        public IEnumerable<Customer> GetCustomersBySpecifiedOrder(int yearOfOrder, string shipCoutry)
        {
            var searchedOrders = database.Orders.Where(o => o.OrderDate.Value.Year == yearOfOrder && o.ShipCountry == shipCoutry).ToList();
            var searchedCustomers = searchedOrders.Select(c => c.Customer);
            return searchedCustomers;
        }

        public IEnumerable<Customer> GetCustomersBySpecifiedOrderUsingNativeQuery(int yearOfOrder, string shipCoutry)
        {
            var ctx = new NorthwindEntities();
            var query = $@"SELECT c.[CustomerID]
      ,c.[CompanyName]
      ,c.[ContactName]
      ,c.[ContactTitle]
      ,c.[Address]
      ,c.[City]
      ,c.[Region]
      ,c.[PostalCode]
      ,c.[Country]
      ,c.[Phone]
      ,c.[Fax]
  FROM [Northwind].[dbo].[Orders] as o
  JOIN [dbo].[Customers] as c
  ON o.CustomerID = c.CustomerID
  WHERE o.OrderDate >= '{yearOfOrder}' AND o.OrderDate < '1998' AND o.ShipCountry = '{shipCoutry}'";

            var searchedCustomers = ctx.Database.SqlQuery<Customer>(query);
            return searchedCustomers;
        }
    }
}
