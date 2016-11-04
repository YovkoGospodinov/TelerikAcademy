using NorthWind.Data.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace NorthWind.Data.Interfaces
{
    public interface INorthwindEntities
    {
        DbSet<Category> Categories { get; set; }
        DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Order_Detail> Order_Details { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Region> Regions { get; set; }
        DbSet<Shipper> Shippers { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<Territory> Territories { get; set; }
        DbSet<Alphabetical_list_of_product> Alphabetical_list_of_products { get; set; }
        DbSet<Category_Sales_for_1997> Category_Sales_for_1997 { get; set; }
        DbSet<Current_Product_List> Current_Product_Lists { get; set; }
        DbSet<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_Cities { get; set; }
        DbSet<Invoice> Invoices { get; set; }
        DbSet<Order_Details_Extended> Order_Details_Extendeds { get; set; }
        DbSet<Order_Subtotal> Order_Subtotals { get; set; }
        DbSet<Orders_Qry> Orders_Qries { get; set; }
        DbSet<Product_Sales_for_1997> Product_Sales_for_1997 { get; set; }
        DbSet<Products_Above_Average_Price> Products_Above_Average_Prices { get; set; }
        DbSet<Products_by_Category> Products_by_Categories { get; set; }
        DbSet<Sales_by_Category> Sales_by_Categories { get; set; }
        DbSet<Sales_Totals_by_Amount> Sales_Totals_by_Amounts { get; set; }
        DbSet<Summary_of_Sales_by_Quarter> Summary_of_Sales_by_Quarters { get; set; }
        DbSet<Summary_of_Sales_by_Year> Summary_of_Sales_by_Years { get; set; }
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
    }
}
