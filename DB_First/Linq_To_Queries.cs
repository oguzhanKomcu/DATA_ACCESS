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
    public partial class Query_Examples : Form
    {
        public Query_Examples()
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

            //OrderByDescending() and OrderBy() = Orderby sorts from least to most, or sorts alphabetically (a-z).OrderByDefault, on the other hand, performs many-to-less sorting and alphabetical (z-a) sorting.

            //Take() =It works like the TOP query in SQL. It returns the data at the top of the table according to the desired number.


            dataGridView1.DataSource = db.Tires.Where(x => x.SalePrice > 2000 && x.SalePrice < 3000).OrderBy(x => x.SalePrice).Take(1).ToList();

        }

        private void Example8_Click(object sender, EventArgs e)
        {
            //Skip() => It is a method that allows us to skip the top x rows from the returned query result and show the number of rows after those rows on the screen.

            dataGridView1.DataSource = db.OrdersDetails.OrderByDescending(x=> x.Total_Fee).Skip(3).Take(3).ToList();    
        }

        private void Example10_Click(object sender, EventArgs e)
        {
            //CONTAİNS() = It checks whether the given expression is in the specified column and returns the row of the passed data.It has case sensitivity. Be careful.In bool data type, it returns true-false.

            dataGridView1.DataSource = db.Customers.Where(x => x.Phone.Contains("533")).ToList();
        }

        private void btnExample11_Click(object sender, EventArgs e)
        {
            //StartWith() => This query returns whatever data is at the beginning of the specified expression.It has case sensitivity. Be careful.In bool data type, it returns true-false.
            dataGridView1.DataSource = db.Employees.Where(x => x.City.StartsWith("An")).ToList();

        }

        private void btnExample12_Click(object sender, EventArgs e)
        {
            //EndsWith() => This query returns data that matches the specified expression and the end of the data.It has case sensitivity. Be careful.In bool data type, it returns true-false.
            dataGridView1.DataSource = db.Employees.Where(x => x.City.EndsWith("bul")).ToList();

        }

        private void btnExample13_Click(object sender, EventArgs e)
        {
            // ANY() => The Any method, which has two different uses, can check whether there is a record in a table with its first use. The second use is to check whether the conditions given in the table are suitable records. Any returns a boolean(true/false) data type as a result.

            bool result = db.Suppliers.Any(x => x.City == "İzmir");

            if (result)
            {
                MessageBox.Show("There is no supplier in the city you are looking for.");

            }
            else
            {
                MessageBox.Show("You have a supplier in the city you are looking for.");

            }

        }
    }
}
