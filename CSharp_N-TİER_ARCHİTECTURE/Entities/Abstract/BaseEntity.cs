
using CSharp_N_TİER_ARCHİTECTURE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase_Project.Models.Entities.Abstract
{
    public abstract class BaseEntity
    {

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; } 
        public DateTime? DeleteDate { get; set; }

        public Status Status { get; set; }
    }
}
