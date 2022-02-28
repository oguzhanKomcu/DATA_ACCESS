using BankDatabase_Project.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase_Project.Infrastructure.Repositories.Abstract
{
    public abstract class KernelRepository
    {

        public BankDatabaseContext db;


        public KernelRepository()
        {
            db = new BankDatabaseContext();

        }



    }
}
