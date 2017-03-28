namespace InventoryManagement
{
    partial class PrintSale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSalePrint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScustna = new System.Windows.Forms.Label();
            this.btnScustPh = new System.Windows.Forms.Label();
            this.btnSsaleman = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndiscount = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCusSign = new System.Windows.Forms.Label();
            this.btnEmpSign = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalePrint
            // 
            this.lblSalePrint.AutoSize = true;
            this.lblSalePrint.Font = new System.Drawing.Font("Franklin Gothic Demi", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrint.Location = new System.Drawing.Point(89, 15);
            this.lblSalePrint.Name = "lblSalePrint";
            this.lblSalePrint.Size = new System.Drawing.Size(581, 101);
            this.lblSalePrint.TabIndex = 0;
            this.lblSalePrint.Text = "XYZ Computers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banani Dhaka";
            // 
            // btnScustna
            // 
            this.btnScustna.AutoSize = true;
            this.btnScustna.Location = new System.Drawing.Point(4, 190);
            this.btnScustna.Name = "btnScustna";
            this.btnScustna.Size = new System.Drawing.Size(153, 25);
            this.btnScustna.TabIndex = 2;
            this.btnScustna.Text = "Customer Name";
            // 
            // btnScustPh
            // 
            this.btnScustPh.AutoSize = true;
            this.btnScustPh.Location = new System.Drawing.Point(8, 247);
            this.btnScustPh.Name = "btnScustPh";
            this.btnScustPh.Size = new System.Drawing.Size(131, 25);
            this.btnScustPh.TabIndex = 3;
            this.btnScustPh.Text = "Phone Nmber";
            // 
            // btnSsaleman
            // 
            this.btnSsaleman.AutoSize = true;
            this.btnSsaleman.Location = new System.Drawing.Point(629, 190);
            this.btnSsaleman.Name = "btnSsaleman";
            this.btnSsaleman.Size = new System.Drawing.Size(159, 25);
            this.btnSsaleman.TabIndex = 4;
            this.btnSsaleman.Text = "Salesman Name:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(640, 225);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 25);
            this.lblUser.TabIndex = 5;
            this.lblUser.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // btndiscount
            // 
            this.btndiscount.AutoSize = true;
            this.btndiscount.Location = new System.Drawing.Point(590, 468);
            this.btndiscount.Name = "btndiscount";
            this.btndiscount.Size = new System.Drawing.Size(89, 25);
            this.btndiscount.TabIndex = 7;
            this.btndiscount.Text = "Discount";
            // 
            // btnTotal
            // 
            this.btnTotal.AutoSize = true;
            this.btnTotal.Location = new System.Drawing.Point(594, 504);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(56, 25);
            this.btnTotal.TabIndex = 8;
            this.btnTotal.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(700, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(700, 501);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 30);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCusSign
            // 
            this.btnCusSign.AutoSize = true;
            this.btnCusSign.Location = new System.Drawing.Point(32, 565);
            this.btnCusSign.Name = "btnCusSign";
            this.btnCusSign.Size = new System.Drawing.Size(188, 25);
            this.btnCusSign.TabIndex = 11;
            this.btnCusSign.Text = "Customer Signature";
            // 
            // btnEmpSign
            // 
            this.btnEmpSign.AutoSize = true;
            this.btnEmpSign.Location = new System.Drawing.Point(374, 565);
            this.btnEmpSign.Name = "btnEmpSign";
            this.btnEmpSign.Size = new System.Drawing.Size(177, 25);
            this.btnEmpSign.TabIndex = 12;
            this.btnEmpSign.Text = "Employee Signatre";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(164, 197);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(0, 25);
            this.lblCustName.TabIndex = 13;
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(169, 254);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(0, 25);
            this.lblCustPhone.TabIndex = 14;
            // 
            // PrintSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCustPhone);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.btnEmpSign);
            this.Controls.Add(this.btnCusSign);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btndiscount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSsaleman);
            this.Controls.Add(this.btnScustPh);
            this.Controls.Add(this.btnScustna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSalePrint);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrintSale";
            this.Size = new System.Drawing.Size(834, 605);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalePrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnScustna;
        private System.Windows.Forms.Label btnScustPh;
        private System.Windows.Forms.Label btnSsaleman;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label btndiscount;
        private System.Windows.Forms.Label btnTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label btnCusSign;
        private System.Windows.Forms.Label btnEmpSign;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustPhone;
    }
}
