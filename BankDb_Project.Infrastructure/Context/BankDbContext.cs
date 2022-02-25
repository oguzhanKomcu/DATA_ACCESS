using BankDb_Project.Infrastructure.EntityTypeConfiguration.Concrete;
using BankDb_Project.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDb_Project.Infrastructure.Context
{
    public  class  BankDbContext : DbContext
    {



        public BankDbContext()
        {


            Database.Connection.ConnectionString = @"Server= DESKTOP-97DV3CH\SQLEXPRESS; Database = BankDb;Integrated Security=True;";

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
