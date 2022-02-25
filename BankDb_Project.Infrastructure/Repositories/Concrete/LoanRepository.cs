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
    public class LoanRepository : KernelRepository, IBaseRepository<Loan>
    {
        public void Create(Loan item)
        {
            item.Status = Status.Active;
            item.CreateDate = DateTime.Now;
            db.Loanes.Add(item);
            db.SaveChanges();
        }

        public void Delete(Loan item)
        {
            item.Status = Status.Passive;
            item.DeleteDate = DateTime.Now;
        }

        public Loan GetByDefault(Expression<Func<Loan, bool>> exp)
        {
            return db.Loanes.FirstOrDefault(exp);
        }

        public List<Loan> GetByDefaults(Expression<Func<Loan, bool>> exp)
        {
            return db.Loanes.Where(exp).ToList();
        }

        public void Update(Loan item)
        {
            Loan loan = GetByDefault(x => x.Id == item.Id);

            loan.Status = Status.Modified;
            loan.UpdateDate = DateTime.Now;
            loan.Loan_Amount = item.Loan_Amount;
            loan.Date_Issued = item.Date_Issued;
            db.SaveChanges();
        }
    
    }
}
