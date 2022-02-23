using BankDatabase_Project.Infrastructure.EntityTypeConfiguration.Abstract;
using BankDatabase_Project.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase_Project.Infrastructure.EntityTypeConfiguration.Concrete
{
    public class TransactionMap : BaseMap<Transaction>
    {
        public TransactionMap()
        {
            Property(x=> x.Transaction_Type).IsRequired();

            HasRequired(x => x.Account)
              .WithMany(x => x.Transaction)
              .HasForeignKey(x => x.From_Account_Id)
              .WillCascadeOnDelete(false);


            HasRequired(x => x.Account)
            .WithMany(x => x.Transaction)
              .HasForeignKey(x => x.To_Account_Id)
                .WillCascadeOnDelete(false);

            Property(x => x.Date_İssued).IsRequired();
            Property(x=> x.Amount).IsRequired();
            Property(x => x.Transaction_Medium).IsRequired();



        }
    }
}
