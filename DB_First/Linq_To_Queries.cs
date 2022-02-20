using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_First
{
    public partial class ExamplesFrom : Form
    {
        public ExamplesFrom()
        {
            InitializeComponent();
        }

        tire_and_rim_shopEntities db = new tire_and_rim_shopEntities();

        private void Example1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tires.ToList();
        }

        private void Example2_Click(object sender, EventArgs e)
        {
            //Select() => It returns only the data in the selected columns of the table. It works similar to the select query in SQL.

            dataGridView1.DataSource = db.Orders.Select(d => new { d.OrdersId , d.CustomerId , d.Customer,d.OrdarDate,d.OrdersDetails}).ToList();
        }

        private void Example4_Click(object sender, EventArgs e)
        {
            //Where() => It brings the data according to the desired conditions. It works in the same logic as where in SQL. 

            dataGridView1.DataSource = db.Rims.Where(x => x.RimsId == 15).Select(x=>new {x.RimsId,x.Offset,x.Diameter,x.Width ,x.Material,x.UnıtsInStock,x.SalePrice }).ToList();
        }

        private void Example9_Click(object sender, EventArgs e)
        {
           

            dataGridView1.DataSource = db.Tires.Where(x => x.SalePrice >1500  && x.SalePrice<3000).Select(x => new { x.TiresId, x.Diameter, x.Thickness, x.Width,x.Brand, x.UnıtsInStock, x.SalePrice }).ToList();
        }

        private void Example5_Click(object sender, EventArgs e)
        {

            //First() => Returns the first value according to the given conditions. If the data entry is incorrect, it throws an exception. It does not work with the if block.

            try
            {
                Tire tire = db.Tires.First(x => x.Diameter > 17 && x.Diameter < 15); 

                MessageBox.Show($"Id : {tire.TiresId}\nName : {tire.SalePrice}");
            }
            catch (Exception)
            {

                MessageBox.Show("The product you are looking for does not exist.!!");

            }
        }

        private void Example6_Click(object sender, EventArgs e)
        {
            //FirtToDefault() => It has the same use as First. However, it does not throw an exception when no data is found here. Instead, it returns a null value. We can check this with the if block. 

            Rim rim = db.Rims.FirstOrDefault(x => x.Diameter > 15);

            if (rim == null)
            {
                MessageBox.Show("The product you are looking for does not exist.!!");
            }
            else
            {
                MessageBox.Show($"ID: {rim.RimsId}\nStock: {rim.UnıtsInStock}");

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Find() => It is used to access a single row in the tables in the database. All information about the selected Id comes directly.

            Employee employee = db.Employees.Find(5);

            if (employee == null)
            {
                MessageBox.Show("The employee you are looking for does not exist.!!");
            }
            else
            {
                MessageBox.Show($"Id: {employee.EmployeeId}\nFull Name : {employee.EmployeeName}");

            }
        }

        private void Example7_Click(object sender, EventArgs e)
        {

        }
    }
}
