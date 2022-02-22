using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Example.Model.Entities.Abstract
{
    public enum Status { Active = 1, Modified = 2, Passive = 3 }
    public abstract class BaseEntity
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        private DateTime _createdate = DateTime.Now;
        public DateTime CreateDate
        {
            get => _createdate;
            set => _createdate = value;

        }


        [Column(TypeName = "datetime2", Order = 8)]

       
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
