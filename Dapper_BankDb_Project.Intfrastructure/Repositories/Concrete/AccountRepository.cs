

using Dapper;
using Dapper_BankDb_Project.Intfrastructure.Repositories.Abstract;
using Dapper_BankDb_Project.Intfrastructure.Repositories.Interface;
using Dapper_BankDb_Project.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_BankDb_Project.Intfrastructure.Repositories.Concrete
{
    public class AccountRepository : KernelRepository, IBaseRepository<Account>
    {

        //Here, I worked by writing direct Sql queries in my program.

        public IEnumerable<Account> All()
        {

            //We use "Query" in Read queries. "Queries" is important here because we only want to show the data as there is no insert, delete or update operation.
            return con.Query<Account>("Select * from Accounts").ToList();
        }

        public void Create(Account entity)
        {
            //Since we are adding, we send our Sql query to the database by doing "Execute" here. When sending it to the database, we specify the parameters it will receive in "param".

            entity.Id = con.Execute(
                "Insert into Accounts(Customer_Id, Balance, Account_Status, Account_Type, Currency) Values(@CustomerId,@Balance,@Accountstatus,@AccountType,@Currency); ",
                param: new { @CustomerId = entity.Customer_Id, @Balance = entity.Balance, @Accountstatus = entity.Account_Status, @AccountType = entity.Account_Type, @Currency = entity.Currency });
        }

        public void Delete(Account entity)
        {

            //It should not be forgotten to specify the "Id" while performing the "delete" operation. Otherwise, there is a possibility that the entire table will be deleted.
            con.Execute("Delete from Accounts where Id = @Id",
                param: new { @Id = entity.Id });
        }

        public Account GetByIdCard(string idcardno)
        {
            //Here I brought it from "Id". I had found it from "Id_Card_No" in my "Customer" repository.

            Account account = con.Query<Account>("Select * from Accounts where Id = @Id",

                param: new { @Id = idcardno }).FirstOrDefault();
            return account;
        }

        public void Update(Account entity)
        {
            //Here I would like to say. Pay attention to the column names. :D
            con.Execute(@"Update Accounts Set Customer_Id = @CustomerId,  Balance = @Balance, Account_Status = @Accountstatus, Account_Type = @AccountType,
                                     Currency = @Currency
                                    
                                     where Id = @Id",
               param: new { @Id = entity.Id, @CustomerId = entity.Customer_Id, @Balance = entity.Balance, @Accountstatus = entity.Account_Status, @AccountType = entity.Account_Type, @Currency = entity.Currency });
        }
    }
}
