using BankaDatabase_Project.Models.Entities.Concrete;
using BankDatabase_Project.Infrastructure.EntityTypeConfiguration.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase_Project.Infrastructure.Context
{
    public class BankDatabaseContext : DbContext
    {

        public BankDatabaseContext()
        {


            Database.Connection.ConnectionString = @"Server= DESKTOP-97DV3CH\SQLEXPRESS; Database = BankDatabase1;Integrated Security=True;";

        }


       
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Loan> Loanes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new BranchMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new LoanMap());
            modelBuilder.Configurations.Add(new TransactionMap());

            base.OnModelCreating(modelBuilder);
        }






    }
}
