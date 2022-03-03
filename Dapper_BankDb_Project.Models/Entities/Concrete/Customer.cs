using Dapper_BankDb_Project.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_BankDb_Project.Models.Entities.Concrete
{
    public class Customer : BaseEntity
    {

        //  I created the exact equivalent of my database here.Otherwise, there will be incompatibility and we will get an error.

        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Id_Card_No { get; set; } //I gave it in the "string" data type to give a character restriction and I won't be doing any more mathematical operations anyway.
        public string Mobile_No { get; set; } //I gave it in the "string" data type to give a character restriction and I won't be doing any more mathematical operations anyway.

        public string Home_Address { get; set; }
        public string Business_Address { get; set; }

        public string City { get; set; }
        public string Email { get; set; }



    }
}
