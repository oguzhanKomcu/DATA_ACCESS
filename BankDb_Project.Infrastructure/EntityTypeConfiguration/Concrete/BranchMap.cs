﻿using BankDb_Project.Infrastructure.EntityTypeConfiguration.Abstract;
using BankDb_Project.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDb_Project.Infrastructure.EntityTypeConfiguration.Concrete
{
    public class BranchMap : BaseMap<Branch>
    {
        public BranchMap()
        {
            Property(x => x.Branch_Name).IsRequired();
            Property(x => x.Branch_Location).IsRequired();

        }
    }
}
