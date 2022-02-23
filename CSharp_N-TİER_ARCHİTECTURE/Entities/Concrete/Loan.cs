using CSharp_N_TİER_ARCHİTECTURE.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_N_TİER_ARCHİTECTURE.Entities.Concrete
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
