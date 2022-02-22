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

    [Table("Order_Items")]
    public  class Order_Item : BaseEntity
    {

        [ForeignKey("Order")]
        public int Order_Id { get; set; }
        public virtual Order Order { get; set; }

        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        public virtual Product Product { get; set; }


        [Required]
        public int Quantity { get; set; }

        [Required]
        public int Unit_Price { get; set; }

     


    }
}
