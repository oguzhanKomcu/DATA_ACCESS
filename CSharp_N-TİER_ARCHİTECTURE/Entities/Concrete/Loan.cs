
using BankDatabase_Project.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase_Project.Models.Entities.Concrete
{
    public class Loan : BaseEntity
    {
        public int Customer_Id { get; set; }
        public virtual Customer Customer { get; set; }

        public int Branch_Id { get; set; }
        public virtual Branch Branch { get; set; }

        public string Loan_Amount { get; set; }
        public DateTime? Date_Issued { get; set; }



    }
}
