using Code_First_Example.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Example.Model.Entities.Concrete
{
    [Table("Orders")]
    public class Order :BaseEntity
    {

      
        [ForeignKey("Customers")]
        public int Customer_Id { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Employees")]
        public int Employee_Id { get; set; }
        public virtual Employee Employee { get; set; }

        [Column(TypeName = "datetime2", Order = 3)]
        public DateTime Order_Date { get; set; }

        public virtual List<Order_Item> Order_Items { get; set; }


    }
}
