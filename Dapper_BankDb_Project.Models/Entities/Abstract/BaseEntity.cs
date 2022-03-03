using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_BankDb_Project.Models.Entities.Abstract
{
    public abstract class BaseEntity
    {
        //Here I created the "Id" that I need to use in the tables. Depending on the situation, "CreateDate,UpdateDate,DeleteDate" can be created.
        public int Id { get; set; }







    }
}
