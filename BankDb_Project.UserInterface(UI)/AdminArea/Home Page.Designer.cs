namespace BankDb_Project.UserInterface_UI_.AdminArea
{
    partial class Home_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAccount,
            this.toolStripMenuItemCustomer,
            this.toolStripMenuItemTransaction,
            this.toolStripMenuItemLoan,
            this.toolStripMenuItemBranch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1279, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItemAccount
            // 
            this.toolStripMenuItemAccount.Name = "toolStripMenuItemAccount";
            this.toolStripMenuItemAccount.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItemAccount.Text = "Account Page";
            this.toolStripMenuItemAccount.Click += new System.EventHandler(this.toolStripMenuItemAccount_Click);
            // 
            // toolStripMenuItemCustomer
            // 
            this.toolStripMenuItemCustomer.Name = "toolStripMenuItemCustomer";
            this.toolStripMenuItemCustomer.Size = new System.Drawing.Size(100, 20);
            this.toolStripMenuItemCustomer.Text = "Customer Page";
            this.toolStripMenuItemCustomer.Click += new System.EventHandler(this.toolStripMenuItemCustomer_Click);
            // 
            // toolStripMenuItemTransaction
            // 
            this.toolStripMenuItemTransaction.Name = "toolStripMenuItemTransaction";
            this.toolStripMenuItemTransaction.Size = new System.Drawing.Size(108, 20);
            this.toolStripMenuItemTransaction.Text = "Transaction Page";
            this.toolStripMenuItemTransaction.Click += new System.EventHandler(this.toolStripMenuItemTransaction_Click);
            // 
            // toolStripMenuItemLoan
            // 
            this.toolStripMenuItemLoan.Name = "toolStripMenuItemLoan";
            this.toolStripMenuItemLoan.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItemLoan.Text = "Loan Page";
            this.toolStripMenuItemLoan.Click += new System.EventHandler(this.toolStripMenuItemLoan_Click);
            // 
            // toolStripMenuItemBranch
            // 
            this.toolStripMenuItemBranch.Name = "toolStripMenuItemBranch";
            this.toolStripMenuItemBranch.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItemBranch.Text = "Branch";
            this.toolStripMenuItemBranch.Click += new System.EventHandler(this.toolStripMenuItemBranch_Click);
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1279, 546);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home_Page";
            this.Text = "Home_Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAccount;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCustomer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTransaction;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBranch;
    }
}