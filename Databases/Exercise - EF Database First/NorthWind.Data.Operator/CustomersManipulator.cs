using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NorthWind.Data.Data;
using NorthWind.Data.Interfaces;

namespace NorthWind.Data.Operator
{
    public class CustomersManipulator
    {
        private INorthwindEntities database;

        public CustomersManipulator(INorthwindEntities db)
        {
            this.database = db;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            var customers = database.Customers.AsEnumerable();

            return customers;
        }

        public void InserCustomer(Customer customer)
        {
            database.Customers.Add(customer);
            database.SaveChanges();
        }

        public void ModifyingCustomer(Customer customer)
        {
            var entry = database.Entry(customer);
            entry.State = EntityState.Modified;
            database.SaveChanges();
        }

        public void DeletingCustomer(string customerId)
        {
            var customerToRemove = database.Customers.FirstOrDefault(c => c.CustomerID == customerId);
            if (customerToRemove != null)
            {
                database.Customers.Remove(customerToRemove);
                database.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Customer with provided Id does not exist in the database!");
            }
        }
    }
}
