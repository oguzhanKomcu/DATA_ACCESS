using Dapper_BankDb_Project.Intfrastructure.Repositories.Concrete;
using Dapper_BankDb_Project.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_BankDb_Project.UserInterface
{
    public partial class AccountCrud : Form
    {
        public AccountCrud()
        {
            InitializeComponent();
        }

        AccountRepository accountRepository = new AccountRepository();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Account account = new Account();

            account.Customer_Id = int.Parse(textCustomerId.Text);
            account.Balance = int.Parse(textBalance.Text);
            account.Account_Status = textAccountStatus.Text;
            account.Account_Type = textAccountType.Text;
            account.Currency = textCurrency.Text;


            accountRepository.Create(account);

            dataGridView1.DataSource = accountRepository.All();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Account account = accountRepository.GetByIdCard(textFindId.Text);
            textCustomerIdUpdate.Text = account.Customer_Id.ToString();
            textBalanceUpdate.Text = account.Balance.ToString();
            textAccountStatusUpdate.Text = account.Account_Status;
            textAccountTypeUpdate.Text = account.Account_Type;
            textCurrencyUpdate.Text = account.Currency;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Id = int.Parse(textFindId.Text);
            account.Customer_Id = int.Parse(textCustomerIdUpdate.Text);
            account.Balance = int.Parse(textBalanceUpdate.Text);
            account.Account_Status = textAccountStatusUpdate.Text;
            account.Account_Type = textAccountTypeUpdate.Text;
            account.Currency = textCurrencyUpdate.Text;


            accountRepository.Update(account);

            dataGridView1.DataSource = accountRepository.All();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Account account = new Account();


            account.Id = int.Parse(textIdDelete.Text);
            accountRepository.Delete(account);

            dataGridView1.DataSource = accountRepository.All();

        }

        private void AccountCrud_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = accountRepository.All();

        }
    }
}
