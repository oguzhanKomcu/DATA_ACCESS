namespace BankaDatabase_Project.UserInterface_UI_
{
    partial class AccountCrud
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
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textAccountType = new System.Windows.Forms.TextBox();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.textCurrency = new System.Windows.Forms.TextBox();
            this.textCustomerId = new System.Windows.Forms.TextBox();
            this.groupUpdateCustomer = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textAccountTypeUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBalanceUpdate = new System.Windows.Forms.TextBox();
            this.textCurrencyUpdate = new System.Windows.Forms.TextBox();
            this.textFindId = new System.Windows.Forms.TextBox();
            this.textCustomerIdUpdate = new System.Windows.Forms.TextBox();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textIdDelete = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboAccountStatus = new System.Windows.Forms.ComboBox();
            this.comboAccountStatusUpdate = new System.Windows.Forms.ComboBox();
            this.grpCreate.SuspendLayout();
            this.groupUpdateCustomer.SuspendLayout();
            this.grpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.comboAccountStatus);
            this.grpCreate.Controls.Add(this.btnCreate);
            this.grpCreate.Controls.Add(this.label4);
            this.grpCreate.Controls.Add(this.label2);
            this.grpCreate.Controls.Add(this.label3);
            this.grpCreate.Controls.Add(this.label5);
            this.grpCreate.Controls.Add(this.label1);
            this.grpCreate.Controls.Add(this.textAccountType);
            this.grpCreate.Controls.Add(this.textBalance);
            this.grpCreate.Controls.Add(this.textCurrency);
            this.grpCreate.Controls.Add(this.textCustomerId);
            this.grpCreate.Location = new System.Drawing.Point(47, 28);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(366, 310);
            this.grpCreate.TabIndex = 7;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create Account";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(185, 205);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(155, 56);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Account_Type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Account_Status : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Currency :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Id : ";
            // 
            // textAccountType
            // 
            this.textAccountType.Location = new System.Drawing.Point(185, 123);
            this.textAccountType.Name = "textAccountType";
            this.textAccountType.Size = new System.Drawing.Size(169, 23);
            this.textAccountType.TabIndex = 0;
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(185, 65);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(169, 23);
            this.textBalance.TabIndex = 0;
            // 
            // textCurrency
            // 
            this.textCurrency.Location = new System.Drawing.Point(185, 152);
            this.textCurrency.Name = "textCurrency";
            this.textCurrency.Size = new System.Drawing.Size(169, 23);
            this.textCurrency.TabIndex = 0;
            // 
            // textCustomerId
            // 
            this.textCustomerId.Location = new System.Drawing.Point(185, 36);
            this.textCustomerId.Name = "textCustomerId";
            this.textCustomerId.Size = new System.Drawing.Size(169, 23);
            this.textCustomerId.TabIndex = 0;
            // 
            // groupUpdateCustomer
            // 
            this.groupUpdateCustomer.Controls.Add(this.comboAccountStatusUpdate);
            this.groupUpdateCustomer.Controls.Add(this.btnFind);
            this.groupUpdateCustomer.Controls.Add(this.btnUpdate);
            this.groupUpdateCustomer.Controls.Add(this.label10);
            this.groupUpdateCustomer.Controls.Add(this.label9);
            this.groupUpdateCustomer.Controls.Add(this.label18);
            this.groupUpdateCustomer.Controls.Add(this.label8);
            this.groupUpdateCustomer.Controls.Add(this.label7);
            this.groupUpdateCustomer.Controls.Add(this.textAccountTypeUpdate);
            this.groupUpdateCustomer.Controls.Add(this.label6);
            this.groupUpdateCustomer.Controls.Add(this.textBalanceUpdate);
            this.groupUpdateCustomer.Controls.Add(this.textCurrencyUpdate);
            this.groupUpdateCustomer.Controls.Add(this.textFindId);
            this.groupUpdateCustomer.Controls.Add(this.textCustomerIdUpdate);
            this.groupUpdateCustomer.Location = new System.Drawing.Point(448, 28);
            this.groupUpdateCustomer.Name = "groupUpdateCustomer";
            this.groupUpdateCustomer.Size = new System.Drawing.Size(366, 310);
            this.groupUpdateCustomer.TabIndex = 8;
            this.groupUpdateCustomer.TabStop = false;
            this.groupUpdateCustomer.Text = "Update Account";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(262, 51);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 25);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(186, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 43);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Account_Type : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Balance : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(132, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 15);
            this.label18.TabIndex = 4;
            this.label18.Text = "Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Account_Status : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Currency :";
            // 
            // textAccountTypeUpdate
            // 
            this.textAccountTypeUpdate.Location = new System.Drawing.Point(185, 176);
            this.textAccountTypeUpdate.Name = "textAccountTypeUpdate";
            this.textAccountTypeUpdate.Size = new System.Drawing.Size(169, 23);
            this.textAccountTypeUpdate.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Customer Id : ";
            // 
            // textBalanceUpdate
            // 
            this.textBalanceUpdate.Location = new System.Drawing.Point(185, 118);
            this.textBalanceUpdate.Name = "textBalanceUpdate";
            this.textBalanceUpdate.Size = new System.Drawing.Size(169, 23);
            this.textBalanceUpdate.TabIndex = 0;
            // 
            // textCurrencyUpdate
            // 
            this.textCurrencyUpdate.Location = new System.Drawing.Point(185, 205);
            this.textCurrencyUpdate.Name = "textCurrencyUpdate";
            this.textCurrencyUpdate.Size = new System.Drawing.Size(169, 23);
            this.textCurrencyUpdate.TabIndex = 0;
            // 
            // textFindId
            // 
            this.textFindId.Location = new System.Drawing.Point(185, 51);
            this.textFindId.Name = "textFindId";
            this.textFindId.Size = new System.Drawing.Size(68, 23);
            this.textFindId.TabIndex = 0;
            // 
            // textCustomerIdUpdate
            // 
            this.textCustomerIdUpdate.Location = new System.Drawing.Point(185, 89);
            this.textCustomerIdUpdate.Name = "textCustomerIdUpdate";
            this.textCustomerIdUpdate.Size = new System.Drawing.Size(169, 23);
            this.textCustomerIdUpdate.TabIndex = 0;
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.label17);
            this.grpDelete.Controls.Add(this.textIdDelete);
            this.grpDelete.Location = new System.Drawing.Point(860, 40);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(319, 187);
            this.grpDelete.TabIndex = 9;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "DELETE ACCOUNT";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(158, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 45);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(68, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 15);
            this.label17.TabIndex = 4;
            this.label17.Text = " ID :";
            // 
            // textIdDelete
            // 
            this.textIdDelete.Location = new System.Drawing.Point(155, 67);
            this.textIdDelete.Name = "textIdDelete";
            this.textIdDelete.Size = new System.Drawing.Size(131, 23);
            this.textIdDelete.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1275, 250);
            this.dataGridView1.TabIndex = 10;
            // 
            // comboAccountStatus
            // 
            this.comboAccountStatus.FormattingEnabled = true;
            this.comboAccountStatus.Items.AddRange(new object[] {
            "Active",
            "Passive",
            "Modified"});
            this.comboAccountStatus.Location = new System.Drawing.Point(186, 94);
            this.comboAccountStatus.Name = "comboAccountStatus";
            this.comboAccountStatus.Size = new System.Drawing.Size(168, 23);
            this.comboAccountStatus.TabIndex = 3;
            // 
            // comboAccountStatusUpdate
            // 
            this.comboAccountStatusUpdate.FormattingEnabled = true;
            this.comboAccountStatusUpdate.Items.AddRange(new object[] {
            "Active",
            "Passive",
            "Modified"});
            this.comboAccountStatusUpdate.Location = new System.Drawing.Point(185, 147);
            this.comboAccountStatusUpdate.Name = "comboAccountStatusUpdate";
            this.comboAccountStatusUpdate.Size = new System.Drawing.Size(168, 23);
            this.comboAccountStatusUpdate.TabIndex = 7;
            // 
            // AccountCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 649);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.groupUpdateCustomer);
            this.Controls.Add(this.grpCreate);
            this.Name = "AccountCrud";
            this.Text = "AccountCrud";
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.groupUpdateCustomer.ResumeLayout(false);
            this.groupUpdateCustomer.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpCreate;
        private Button btnCreate;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label1;
        private TextBox textAccountType;
        private TextBox textBalance;
        private TextBox textCurrency;
        private TextBox textCustomerId;
        private GroupBox groupUpdateCustomer;
        private Button btnFind;
        private Button btnUpdate;
        private Label label10;
        private Label label9;
        private Label label18;
        private Label label8;
        private Label label7;
        private TextBox textAccountTypeUpdate;
        private Label label6;
        private TextBox textBalanceUpdate;
        private TextBox textCurrencyUpdate;
        private TextBox textFindId;
        private TextBox textCustomerIdUpdate;
        private GroupBox grpDelete;
        private Button btnDelete;
        private Label label17;
        private TextBox textIdDelete;
        private DataGridView dataGridView1;
        private ComboBox comboAccountStatus;
        private ComboBox comboAccountStatusUpdate;
    }
}