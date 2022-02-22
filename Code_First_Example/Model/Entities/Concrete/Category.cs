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
    [Table("Categories")]
    public  class Category :BaseEntity
    {

        [Required]
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
