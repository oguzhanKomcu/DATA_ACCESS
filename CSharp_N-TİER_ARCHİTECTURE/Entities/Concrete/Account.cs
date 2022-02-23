using CSharp_N_TİER_ARCHİTECTURE.Entities.Abstract;
using CSharp_N_TİER_ARCHİTECTURE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_N_TİER_ARCHİTECTURE.Entities.Concrete
{
    public class Account : BaseEntity
    {

        public int Customer_Id { get; set; }
        public virtual  Customer Customer { get; set; }

        public  int Balance { get; set; }
        public Status Account_Status { get; set; }

        public string Account_Type { get; set; }
        public string Currency { get; set; }


    }
}
