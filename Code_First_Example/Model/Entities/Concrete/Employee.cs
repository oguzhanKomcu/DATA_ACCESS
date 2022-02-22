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
    [Table("Employees")]
    public class Employee :BaseEntity
    {

        [Required]    

        public string First_Name { get; set; }

        [Required]

        public string Last_Name { get; set; }


        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(11)]
        public string PhoneNumber { get; set; }


        [Column(TypeName = "datetime2", Order = 5)]
        public DateTime Hire_Date { get; set; }

       






    }
}
