using BankaDatabase_Project.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDatabase_Project.Models.Entities.Concrete
{
    public  class Transaction :BaseEntity
    {

        public string Transaction_Type { get; set; }

        public int From_Account_Id { get; set; }

        public int To_Account_Id { get; set; }
        public virtual Account Account { get; set; }



        public DateTime? Date_İssued { get; set; }
        public string Amount { get; set; }


        public string Transaction_Medium { get; set; }









    }
}
