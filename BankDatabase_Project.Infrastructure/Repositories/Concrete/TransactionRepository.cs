using BankaDatabase_Project.Models.Entities.Concrete;
using BankaDatabase_Project.Models.Enums;
using BankDatabase_Project.Infrastructure.Repositories.Abstract;
using BankDatabase_Project.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase_Project.Infrastructure.Repositories.Concrete
{
    public class TransactionRepository : KernelRepository, IBaseRepository<Transaction>
    {
        public void Create(Transaction item)
        {
            item.Status = Status.Active;
            item.CreateDate = DateTime.Now;
            db.Transactions.Add(item);
            db.SaveChanges();
        }

        public void Delete(Transaction item)
        {
            item.Status = Status.Passive;
            item.DeleteDate = DateTime.Now;
        }

        public Transaction GetByDefault(Expression<Func<Transaction, bool>> exp)
        {
            return db.Transactions.FirstOrDefault(exp);
        }

        public List<Transaction> GetByDefaults(Expression<Func<Transaction, bool>> exp)
        {
            return db.Transactions.Where(exp).ToList();
        }

        public void Update(Transaction item)
        {
            Transaction transaction = GetByDefault(x => x.Id == item.Id);

            transaction.Status = Status.Modified;
            transaction.UpdateDate = DateTime.Now;
            transaction.Transaction_Type = item.Transaction_Type;
            transaction.From_Account_Id = item.From_Account_Id;
            transaction.To_Account_Id = item.To_Account_Id;
            transaction.Date_İssued = item.Date_İssued;
            transaction.Amount = item.Amount;
            transaction.Transaction_Medium = item.Transaction_Medium;

            db.SaveChanges();
        }
    }
}
