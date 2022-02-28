using BankaDatabase_Project.Models.Entities.Concrete;
using BankDatabase_Project.Infrastructure.EntityTypeConfiguration.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase_Project.Infrastructure.EntityTypeConfiguration.Concrete
{
    public class AccountMap : BaseMap<Account>
    {
        public AccountMap()
        {

            HasRequired(x => x.Customer)
               .WithMany(x => x.Account)
               .HasForeignKey(x => x.Customer_Id)
               .WillCascadeOnDelete(false);

            Property(x => x.Balance).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.Account_Type).IsRequired();
            Property(x => x.Currency).IsRequired();

        }






    }
}
