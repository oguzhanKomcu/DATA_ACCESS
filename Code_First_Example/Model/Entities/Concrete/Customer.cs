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
    [Table("Customers")]
    public class Customer : BaseEntity
    {


        [Required]

        public string First_Name { get; set; }

        [Required]

        public string Last_Name { get; set; }


        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

       





    }
}
