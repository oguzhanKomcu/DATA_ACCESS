using Dapper;
using Dapper_BankDb_Project.Intfrastructure.Repositories.Abstract;
using Dapper_BankDb_Project.Intfrastructure.Repositories.Interface;
using Dapper_BankDb_Project.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_BankDb_Project.Intfrastructure.Repositories.Concrete
{
    public class CustomerRepository : KernelRepository, IBaseRepository<Customer>
    {

        public void Create(Customer entity)
        {
            //I wrote the name of the procedure that I created in Sql in my first parameter.
            //Whichever operation I am going to do, I have to specify the procedure name of that operation by writing it in the first parameter.
            //I have specified my values ​​corresponding to my variables in my procedure in "param".
            //Finally, I specified that my command type is "StoreProcedure".

            entity.Id = con.Execute("InsertCustomer",

               param: new { @FirstName = entity.First_Name, @LastName = entity.Last_Name, @Id_Card_No = entity.Id_Card_No, @Mobile_No = entity.Mobile_No, @Home_Address = entity.Home_Address, @Business_Address = entity.Business_Address, @City = entity.City, @Email = entity.Email }


               , commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<Customer> All()
        {
            return con.Query<Customer>("GetAllCustomers", commandType: CommandType.StoredProcedure).ToList();
        }

        public void Delete(Customer entity)
        {
            con.Execute("DeleteCustomer", param: new { @IdCardNo = entity.Id_Card_No }, commandType: CommandType.StoredProcedure);
        }


        public Customer GetByIdCard(string idcardno)
        {
            Customer customer = con.Query<Customer>("GetByIdCard", param: new { @Idcardno = idcardno }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return customer;
        }

        public void Update(Customer entity)
        {
            entity.Id = con.Execute("UpdateCustomer",

                      param: new { @FirstName = entity.First_Name, @LastName = entity.Last_Name, @Id_Card_No = entity.Id_Card_No, @Mobile_No = entity.Mobile_No, @Home_Address = entity.Home_Address, @Business_Address = entity.Business_Address, @City = entity.City, @Email = entity.Email },


                 commandType: CommandType.StoredProcedure);
        }
    }
}
