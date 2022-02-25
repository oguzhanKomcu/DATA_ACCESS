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
    public class BranchRepository : KernelRepository, IBaseRepository<Branch>
    {
        public void Create(Branch item)
        {
            item.Status = Status.Active;
            item.CreateDate = DateTime.Now;
            db.Branches.Add(item);
            db.SaveChanges();
        }

        public void Delete(Branch item)
        {
            item.Status = Status.Passive;
            item.DeleteDate = DateTime.Now;
        }

        public Branch GetByDefault(Expression<Func<Branch, bool>> exp)
        {
            return db.Branches.FirstOrDefault(exp);
        }

        public List<Branch> GetByDefaults(Expression<Func<Branch, bool>> exp)
        {
            return db.Branches.Where(exp).ToList();
        }

        public void Update(Branch item)
        {
            Branch branch = GetByDefault(x => x.Id == item.Id);

            branch.Status = Status.Modified;
            branch.UpdateDate = DateTime.Now;
            branch.Branch_Name = item.Branch_Name;
            branch.Branch_Location = item.Branch_Location;
            db.SaveChanges();
        }
    }
}
