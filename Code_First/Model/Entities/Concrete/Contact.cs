
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
    [Table("Contacts")]
    public  class Contact :BaseEntity
    {
        [Required]
        public string FirtsName  { get; set; }

        [Required]
        public string LastName  { get; set; }

        [Required]
        public string Email  { get; set; }

        [Required]
        [MaxLength(11)]
        public string PhoneNumber { get; set; }

        //In order to provide the relationship between the tables, we made a foreignkey connection as we did when creating the table in SQL.
        [ForeignKey("Customer")] 
        public int Customer_Id { get; set; }
        public Customer Customer { get; set; }








    }
}
