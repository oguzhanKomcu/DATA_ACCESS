using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_BankDb_Project.Intfrastructure.Repositories.Interface
{
    interface IBaseRepository<T>
    {

        void Create(T entity);

        IEnumerable<T> All();

        void Delete(T entity);

        T GetByIdCard(string idcardno);


        void Update(T entity);












    }
}
