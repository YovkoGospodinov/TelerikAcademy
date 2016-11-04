using NorthWind.Data.Data;
using System;
using System.Linq;

namespace NorthWind.Data.Operator
{
    public class Tester
    {
        private static NorthwindEntities database = new NorthwindEntities();
        private static CustomersManipulator manipulator = new CustomersManipulator(database);
        private static CustomersFinder customersFinder = new CustomersFinder(database);
        private static SalesFinder salesFinder = new SalesFinder(database);

        public static void Main()
        {
            //Problem 02
            CustomersManipulations();

            // Problem 03
            GetCustomers();

            // Problem 04
            GetCustumersWithNativeQuery();

            // Problem 05
            GetSpecifiedSales();
        }

        private static void GetSpecifiedSales()
        {
            var region = "NM";
            var startDate = new DateTime(1998, 05, 05);
            var endDate = new DateTime(1999, 05, 05);
            var orders = salesFinder.GetOrdersBySpecifiedParameters(region, startDate, endDate);

            foreach (var order in orders)
            {
                Console.WriteLine($"Region - {order.ShipRegion} order date {order.OrderDate}");
            }
        }

        private static void CustomersManipulations()
        {
            //Get All Customers
            manipulator.GetAllCustomers().ToList().ForEach(c => Console.WriteLine(c.ContactName));

            //Insert Customer
            var customerToInsert = new Customer()
            {
                ContactName = "Ivan",
                City = "Sofia",
                CustomerID = "BIBIC",
                CompanyName = "PostBank"
            };

            manipulator.InserCustomer(customerToInsert);

            //Modify Customer
            var customerToModfy = new Customer()
            {
                ContactName = "Ivan",
                City = "Sofia",
                CustomerID = "BIBIC",
                CompanyName = "PostBank",
                Country = "Bulgaria",
                PostalCode = "1000"
            };

            manipulator.ModifyingCustomer(customerToModfy);

            //Delete Customer
            var customerId = "BIBIC";
            manipulator.DeletingCustomer(customerId);
        }

        private static void GetCustomers()
        {
            var searchedCustomers = customersFinder.GetCustomersBySpecifiedOrder(1997, "Canada");
            foreach (var customer in searchedCustomers)
            {
                Console.WriteLine(customer.ContactName);
            }
        }

        private static void GetCustumersWithNativeQuery()
        {
            var searchedCustomersNativeQuery = customersFinder.GetCustomersBySpecifiedOrderUsingNativeQuery(1997, "Canada");
            foreach (var customer in searchedCustomersNativeQuery)
            {
                Console.WriteLine(customer.ContactName);
            }
        }
    }
}
