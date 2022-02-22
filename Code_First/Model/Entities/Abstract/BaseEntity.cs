using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.Model.Entities.Abstract
{

    public enum Status { Active = 1, Modified = 2, Passive }  //We created our sequencing outside of the class. Otherwise we would get an error.

    public class BaseEntity
    {

        //We are creating our main entity, but this entity will not be in our database. This entity has transferred the properties inside our sub-assets.

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        private DateTime _createdate = DateTime.Now;
        public DateTime CreateDate
        {
            get => _createdate;
            set => _createdate = value; 
            
        }

        
        [Column(TypeName = "datetime2", Order = 5)]

        //Value types cannot be null. Since UpdateDate and DeleteDate cannot be entered while entering data, we made these colons nullable.
        //We achieved this by doing (Value type+"?" ).
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }




        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }





    }
}
