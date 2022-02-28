using BankaDatabase_Project.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDatabase_Project.Models.Entities.Concrete
{
    public class Customer : BaseEntity
    {
        public byte Id_Card_No { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public string Mobile_No { get; set; }

        public string Home_Address { get; set; }
        public string Business_Address { get; set; }

        public string City { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }

        public virtual List<Account> Account { get; set; }
        public virtual List<Loan> Loan { get; set; }





    }
}
