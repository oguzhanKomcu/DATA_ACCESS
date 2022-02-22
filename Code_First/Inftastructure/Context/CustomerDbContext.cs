using CODE_FİRST.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_FİRST.Inftastructure.Context
{

    public class CustomerDbContext : DbContext 
    {
        //We have inherited our own context class from the DbContext class that comes with the Entity framework. In this way, we will have created our database.

        public CustomerDbContext()
        {

            //We are creating our database while starting our constructor, that is, our class.
            //Pay attention to the server name.
            Database.Connection.ConnectionString = @"Server= DESKTOP-97DV3CH\SQLEXPRESS; Database = CustomerDb;Integrated Security = true";

        }


        //I specified my tables to be created in my database.
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Contact> Contact { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    base.OnModelCreating(modelBuilder);
        //}



        // Tools + NuGet Package Manager + Package Manager Console
        //We did PM > enable-migrations to create and connect the database.



    }
}
