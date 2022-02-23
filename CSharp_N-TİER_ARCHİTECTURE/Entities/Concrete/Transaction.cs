using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_N_TİER_ARCHİTECTURE.Entities.Concrete
{
    public class Transaction
    {
        public string Transaction_Type { get; set; }
        public int  From_Account_Id { get; set; }
        public virtual Account Account { get; set; }
        public int To_Account_Id { get; set; }
        public DateTime? Date_İssued { get; set; }
        public string  Amount { get; set; }


        public string Transaction_Medium { get; set; }






    }
}
