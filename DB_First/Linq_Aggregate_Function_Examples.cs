using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_First
{
    public partial class Linq_Aggregate_Function_Examples : Form
    {
        public Linq_Aggregate_Function_Examples()
        {
            InitializeComponent();
        }

        tire_and_rim_shopEntities db = new tire_and_rim_shopEntities();

        private void btnExample1_Click(object sender, EventArgs e)
        {
            //Count() => Returns the total number of rows.It is used when requested.

            MessageBox.Show($"Count of Tires : { db.Tires.Count()}");
        }

        private void btnExample2_Click(object sender, EventArgs e)
        {
            //Sum() =>It gives the sum of the girths. The sum can be used when requested.
            int? total = db.Tires.Sum(x => x.UnıtsInStock);
            MessageBox.Show($"Total number of tires : { total}");

         

        }

        private void btnExample3_Click(object sender, EventArgs e)
        {
            //Max() => Returns the maximum value in a column.
            MessageBox.Show($"Highest Sales: { db.OrdersDetails.Max(x => x.Total_Fee)}");

        }

        private void btnExample4_Click(object sender, EventArgs e)
        {
            //Min() => Returns the minimum  value in a column.
            MessageBox.Show($"The rim with the lowest selling price : { db.Rims.Min(x => x.SalePrice)}");
        }

        private void btnExample5_Click(object sender, EventArgs e)
        {

            //DateDiff() => It is used in date calculations.
            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                FirstName = x.EmployeeName,
                Address = x.Address,

                Age = SqlFunctions.DateDiff("Year", x.BirtDate, DateTime.Now)


            }).Take(1).OrderBy(x => x.Age).ToList();

        }

        private void btnExample6_Click(object sender, EventArgs e)
        {
            //GroupBy() = It is used to separate the table or tables that are queried together into groups.

            dataGridView1.DataSource = db.OrdersDetails.GroupBy(x => x.Rim.Diameter).Select(x => new
            {
                Diameter = x.Key,
                UnitStock = x.Sum(y=> y.RimsQuantity)

            }).ToList();
        }

        private void btnExample7_Click(object sender, EventArgs e)
        {

            //Join() = We use it when we want to pull more than one data.
            dataGridView1.DataSource = db.Tires

                   .Join(db.TireAndRimSuppliers, t => t.TiresId, tars => tars.TiresId, (t, tars) => new { t, tars }).GroupBy(x => x.tars.SuppliersId)
                   .Select(x => new
                   {
                       SuppliersId = x.Key,
                       UnitStock = x.Sum(b => b.t.UnıtsInStock),

                   }).ToList();


        }
    }
}
