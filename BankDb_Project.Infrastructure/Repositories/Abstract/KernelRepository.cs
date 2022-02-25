using BankDb_Project.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDb_Project.Infrastructure.Repositories.Abstract
{
    public abstract class KernelRepository
    {

        public BankDbContext db;
        

        public KernelRepository()
        {
            db = new BankDbContext();   

        }



    }
}
