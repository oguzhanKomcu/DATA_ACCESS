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
    [Table("Products")]
    public class Product :BaseEntity
    {
        [Required]
        public string Product_Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string Color { get; set; }       
        public int? UnitInStock { get; set; }

        public int Standart_Cost { get; set; }

        public int list_Price { get; set; }


        [ForeignKey("Category")]

        public int CategoryId { get; set; } 
        public virtual Category Category { get; set; } 





    }
}
