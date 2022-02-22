
using Code_First_Example.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_FİRST.Inftastructure.Context
{

    public class StoreDbContext : DbContext 
    {
       

        public StoreDbContext()
        {

           
            Database.Connection.ConnectionString = @"Server= DESKTOP-97DV3CH\SQLEXPRESS; Database = StoreDb;Integrated Security = true";

        }


        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Item> Order_Items { get; set; }
        public DbSet<Product> Product { get; set; }




    }
}
