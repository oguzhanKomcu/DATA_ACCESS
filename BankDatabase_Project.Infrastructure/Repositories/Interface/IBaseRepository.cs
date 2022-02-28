using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase_Project.Infrastructure.Repositories.Interface
{
    public interface IBaseRepository<T>
    {
        void Create(T item);
        void Update(T item);
        void Delete(T item);



        T GetByDefault(Expression<Func<T, bool>> exp);

        List<T> GetByDefaults(Expression<Func<T, bool>> exp);


    }
}
