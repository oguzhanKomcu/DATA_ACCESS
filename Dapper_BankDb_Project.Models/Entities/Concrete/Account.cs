using Dapper_BankDb_Project.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_BankDb_Project.Models.Entities.Concrete
{
    public class Account : BaseEntity
    {
        //  I created the exact equivalent of my database here.Otherwise, there will be incompatibility and we will get an error.
        public int Customer_Id { get; set; }


        public int Balance { get; set; }
        public string Account_Status { get; set; }

        public string Account_Type { get; set; }
        public string Currency { get; set; }



    }
}
