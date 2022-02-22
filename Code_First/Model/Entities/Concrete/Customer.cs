
using Code_First.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.Model.Entities.Concrete
{
    [Table("Customers")]
    public class Customer : BaseEntity
    {


        [Required]     //Here we have specified that this information is not nullable.
        [MinLength(3)]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [Required]
        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerAddress { get; set; }









    }
}
