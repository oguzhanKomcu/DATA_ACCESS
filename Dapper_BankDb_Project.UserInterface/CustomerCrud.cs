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
    public partial class CustomerCrud : Form
    {
        public CustomerCrud()
        {
            InitializeComponent();
        }

        CustomerRepository customerRepository = new CustomerRepository();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.First_Name = textFirstName.Text;
            customer.Last_Name = textLastName.Text;
            customer.Id_Card_No = textIdCardNo.Text;
            customer.Mobile_No = textMobilNo.Text;
            customer.Home_Address = textHomeAddress.Text;
            customer.Business_Address = textBusinessAddress.Text;
            customer.City = textCity.Text;
            customer.Email = textEmail.Text;

            customerRepository.Create(customer);

            dataGridView1.DataSource = customerRepository.All();





        }

        private void btnFind_Click(object sender, EventArgs e)
        {


            Customer customer = customerRepository.GetByIdCard(textFindIdCardNo.Text);
            textFirstNameUpdate.Text = customer.First_Name;
            textLastNameUpdate.Text = customer.Last_Name;
            textIdCardNoUpdate.Text = customer.Id_Card_No;
            textMobilNoUpdate.Text = customer.Mobile_No;
            textHomeAddressUpdate.Text = customer.Home_Address;
            textBusinessAddressUpdate.Text = customer.Business_Address;
            textCityUpdate.Text = customer.City;
            textEmailUpdate.Text = customer.Email;






        }

        private void Crud_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerRepository.All();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.First_Name = textFirstNameUpdate.Text;
            customer.Last_Name = textLastNameUpdate.Text;
            customer.Id_Card_No = textIdCardNoUpdate.Text;
            customer.Mobile_No = textMobilNoUpdate.Text;
            customer.Home_Address = textHomeAddressUpdate.Text;
            customer.Business_Address = textBusinessAddressUpdate.Text;
            customer.City = textCityUpdate.Text;
            customer.Email = textEmailUpdate.Text;

            customerRepository.Update(customer);

            dataGridView1.DataSource = customerRepository.All();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.Id_Card_No = textIdCardNoDelete.Text;
            customerRepository.Delete(customer);

            dataGridView1.DataSource = customerRepository.All();

        }
    }
}
