
using BankDb_Project.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDb_Project.Models.Entities.Concrete
{
    public class Branch : BaseEntity
    {

        public string Branch_Name { get; set; }
        public string Branch_Location { get; set; }


       public virtual List<Loan> Loan { get; set;}


    }
}
