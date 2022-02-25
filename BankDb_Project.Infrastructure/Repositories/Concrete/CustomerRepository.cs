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
    public class CustomerRepository : KernelRepository, IBaseRepository<Customer>
    {
        public void Create(Customer item)
        {

            item.Status = Status.Active;
            item.CreateDate = DateTime.Now;
            db.Customers.Add(item);
            db.SaveChanges();
        }

        public void Delete(Customer item)
        {
            item.Status = Status.Passive;
            item.DeleteDate = DateTime.Now;
        }

        public Customer GetByDefault(Expression<Func<Customer, bool>> exp)
        {
            return db.Customers.FirstOrDefault(exp);
        }

        public List<Customer> GetByDefaults(Expression<Func<Customer, bool>> exp)
        {
            return db.Customers.Where(exp).ToList();
        }

        public void Update(Customer item)
        {
            Customer customer = GetByDefault(x => x.Id == item.Id);

            customer.Status = Status.Modified;
            customer.UpdateDate = DateTime.Now;
            customer.First_Name = item.First_Name;
            customer.Last_Name = item.Last_Name;
            customer.Mobile_No = item.Mobile_No;
            customer.Home_Address = item.Home_Address;
            customer.Business_Address = item.Business_Address;
            customer.City = item.City;
            customer.Email = item.Email;



            db.SaveChanges();
        }
    }
}
