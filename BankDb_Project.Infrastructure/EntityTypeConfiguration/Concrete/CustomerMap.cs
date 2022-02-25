using BankDb_Project.Infrastructure.EntityTypeConfiguration.Abstract;
using BankDb_Project.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDb_Project.Infrastructure.EntityTypeConfiguration.Concrete
{
    public class CustomerMap : BaseMap<Customer>
    {
        public CustomerMap()
        {

            Property(x => x.First_Name).IsRequired();
            Property(x => x.Last_Name).IsRequired();


            Property(x => x.Mobile_No).HasMaxLength(11).IsRequired();
            Property(x => x.Home_Address).IsRequired();
            Property(x => x.Business_Address).IsRequired();
            Property(x => x.City).IsRequired();
            Property(x => x.Email).IsOptional();







        }
    }
}
