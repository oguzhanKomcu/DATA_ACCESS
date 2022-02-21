namespace DB_First
{
    partial class Linq_Aggregate_Function_Examples
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExample1 = new System.Windows.Forms.Button();
            this.btnExample2 = new System.Windows.Forms.Button();
            this.btnExample3 = new System.Windows.Forms.Button();
            this.btnExample4 = new System.Windows.Forms.Button();
            this.btnExample5 = new System.Windows.Forms.Button();
            this.btnExample6 = new System.Windows.Forms.Button();
            this.btnExample7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(24, 291);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(110, 44);
            this.btnExample1.TabIndex = 1;
            this.btnExample1.Text = "COUNT ()";
            this.btnExample1.UseVisualStyleBackColor = true;
            this.btnExample1.Click += new System.EventHandler(this.btnExample1_Click);
            // 
            // btnExample2
            // 
            this.btnExample2.Location = new System.Drawing.Point(160, 291);
            this.btnExample2.Name = "btnExample2";
            this.btnExample2.Size = new System.Drawing.Size(107, 44);
            this.btnExample2.TabIndex = 2;
            this.btnExample2.Text = "SUM ()";
            this.btnExample2.UseVisualStyleBackColor = true;
            this.btnExample2.Click += new System.EventHandler(this.btnExample2_Click);
            // 
            // btnExample3
            // 
            this.btnExample3.Location = new System.Drawing.Point(298, 291);
            this.btnExample3.Name = "btnExample3";
            this.btnExample3.Size = new System.Drawing.Size(98, 44);
            this.btnExample3.TabIndex = 3;
            this.btnExample3.Text = "MAX ()";
            this.btnExample3.UseVisualStyleBackColor = true;
            this.btnExample3.Click += new System.EventHandler(this.btnExample3_Click);
            // 
            // btnExample4
            // 
            this.btnExample4.Location = new System.Drawing.Point(413, 291);
            this.btnExample4.Name = "btnExample4";
            this.btnExample4.Size = new System.Drawing.Size(100, 44);
            this.btnExample4.TabIndex = 4;
            this.btnExample4.Text = "MIN () ";
            this.btnExample4.UseVisualStyleBackColor = true;
            this.btnExample4.Click += new System.EventHandler(this.btnExample4_Click);
            // 
            // btnExample5
            // 
            this.btnExample5.Location = new System.Drawing.Point(550, 291);
            this.btnExample5.Name = "btnExample5";
            this.btnExample5.Size = new System.Drawing.Size(94, 44);
            this.btnExample5.TabIndex = 5;
            this.btnExample5.Text = "DATEDIFF ()";
            this.btnExample5.UseVisualStyleBackColor = true;
            this.btnExample5.Click += new System.EventHandler(this.btnExample5_Click);
            // 
            // btnExample6
            // 
            this.btnExample6.Location = new System.Drawing.Point(690, 291);
            this.btnExample6.Name = "btnExample6";
            this.btnExample6.Size = new System.Drawing.Size(95, 44);
            this.btnExample6.TabIndex = 6;
            this.btnExample6.Text = "GroupBy ()";
            this.btnExample6.UseVisualStyleBackColor = true;
            this.btnExample6.Click += new System.EventHandler(this.btnExample6_Click);
            // 
            // btnExample7
            // 
            this.btnExample7.Location = new System.Drawing.Point(24, 359);
            this.btnExample7.Name = "btnExample7";
            this.btnExample7.Size = new System.Drawing.Size(110, 53);
            this.btnExample7.TabIndex = 7;
            this.btnExample7.Text = "JOIN ()";
            this.btnExample7.UseVisualStyleBackColor = true;
            this.btnExample7.Click += new System.EventHandler(this.btnExample7_Click);
            // 
            // Linq_Aggregate_Function_Examples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 479);
            this.Controls.Add(this.btnExample7);
            this.Controls.Add(this.btnExample6);
            this.Controls.Add(this.btnExample5);
            this.Controls.Add(this.btnExample4);
            this.Controls.Add(this.btnExample3);
            this.Controls.Add(this.btnExample2);
            this.Controls.Add(this.btnExample1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Linq_Aggregate_Function_Examples";
            this.Text = "Linq_Aggregate_Function_Examples";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExample1;
        private System.Windows.Forms.Button btnExample2;
        private System.Windows.Forms.Button btnExample3;
        private System.Windows.Forms.Button btnExample4;
        private System.Windows.Forms.Button btnExample5;
        private System.Windows.Forms.Button btnExample6;
        private System.Windows.Forms.Button btnExample7;
    }
}