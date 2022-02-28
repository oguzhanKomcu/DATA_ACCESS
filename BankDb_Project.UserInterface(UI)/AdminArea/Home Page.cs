using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDb_Project.UserInterface_UI_.AdminArea
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        void ChildForm(Form _chilform)
        {
            //boyutları aynı olması için formların
            this.Width = _chilform.Width;
            this.Height = _chilform.Height;

            bool condition = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _chilform.Text)
                {
                    condition = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }

            if (condition == false)
            {
                _chilform.MdiParent = this;
                _chilform.Show();
            }


        }

        private void toolStripMenuItemAccount_Click(object sender, EventArgs e)
        {
            ChildForm(new Account_Page());

        }

        private void toolStripMenuItemCustomer_Click(object sender, EventArgs e)
        {
            ChildForm(new CUSTOMER_PAGE());
        }

        private void toolStripMenuItemTransaction_Click(object sender, EventArgs e)
        {
            ChildForm(new TRANSACTION_PAGE());
        }

        private void toolStripMenuItemLoan_Click(object sender, EventArgs e)
        {
            ChildForm(new LOAN_PAGE());

        }

        private void toolStripMenuItemBranch_Click(object sender, EventArgs e)
        {
            ChildForm(new BRANCH_PAGE());

        }
    }
}
