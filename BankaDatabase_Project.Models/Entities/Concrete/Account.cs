using BankaDatabase_Project.Models.Entities.Abstract;
using BankaDatabase_Project.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDatabase_Project.Models.Entities.Concrete
{
    public class Account :BaseEntity
    {
        public int Customer_Id { get; set; }
        public virtual Customer Customer { get; set; }

        public int Balance { get; set; }
        public Status Account_Status { get; set; }

        public string Account_Type { get; set; }
        public string Currency { get; set; }

        public virtual List<Transaction> Transaction { get; set; }

    }
}
