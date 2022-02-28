﻿using BankDb_Project.Infrastructure.EntityTypeConfiguration.Abstract;
using BankDb_Project.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDb_Project.Infrastructure.EntityTypeConfiguration.Concrete
{
    public class LoanMap : BaseMap<Loan>
    {
        public LoanMap()
        {
            HasRequired(x => x.Customer)
              .WithMany(x => x.Loan)
              .HasForeignKey(x => x.Customer_Id)
              .WillCascadeOnDelete(false);


            HasRequired(x => x.Branch)
                .WithMany(x => x.Loan)
                .HasForeignKey(x => x.Branch_Id)
                .WillCascadeOnDelete(false);

            Property(x=> x.Loan_Amount).IsRequired();

            Property(x => x.Date_Issued).HasColumnType("datetime2").IsRequired();



        }
    }
}