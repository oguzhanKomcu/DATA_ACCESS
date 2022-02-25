using BankDb_Project.Infrastructure.Repositories.Abstract;
using BankDb_Project.Infrastructure.Repositories.Interface;
using BankDb_Project.Models.Entities.Concrete;
using BankDb_Project.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankDb_Project.Infrastructure.Repositories.Concrete
{
    public class AccountRepository : KernelRepository, IBaseRepository<Account>
    {
        public void Create(Account item)
        {
            item.Status = Status.Active;
            item.CreateDate = DateTime.Now;
            db.Accounts.Add(item);
            db.SaveChanges();
        }

        public void Delete(Account item)
        {
            item.Status = Status.Passive;
            item.DeleteDate = DateTime.Now;
        }

        public Account GetByDefault(Expression<Func<Account, bool>> exp)
        {
            return db.Accounts.FirstOrDefault(exp);
        }

        public List<Account> GetByDefaults(Expression<Func<Account, bool>> exp)
        {
            return db.Accounts.Where(exp).ToList();
        }

        public void Update(Account item)
        {
            Account account = GetByDefault(x => x.Id == item.Id);

            account.Status = Status.Modified;
            account.UpdateDate = DateTime.Now;
            account.Balance = item.Balance;
            account.Account_Status = item.Account_Status;
            account.Account_Type = item.Account_Type;
            account.Currency = item.Currency;
            db.SaveChanges();

        }
    }
}
