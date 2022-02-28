using BankaDatabase_Project.Models.Entities.Concrete;
using BankDatabase_Project.Infrastructure.EntityTypeConfiguration.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase_Project.Infrastructure.EntityTypeConfiguration.Concrete
{
    public  class BranchMap :BaseMap<Branch>
    {

        public BranchMap()
        {
            Property(x => x.Branch_Name).IsRequired();
            Property(x => x.Branch_Location).IsRequired();

        }


    }
}
