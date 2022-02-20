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
    }
}
