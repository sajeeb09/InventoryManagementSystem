namespace InventoryManagement
{
    partial class Brands
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnUpdateBrand = new System.Windows.Forms.Button();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.gridBrand = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDeleteBrands = new System.Windows.Forms.Button();
            this.btnSearchBrand = new System.Windows.Forms.Button();
            this.tbBrands = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 381);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 13;
            // 
            // btnUpdateBrand
            // 
            this.btnUpdateBrand.Location = new System.Drawing.Point(17, 242);
            this.btnUpdateBrand.Name = "btnUpdateBrand";
            this.btnUpdateBrand.Size = new System.Drawing.Size(112, 36);
            this.btnUpdateBrand.TabIndex = 12;
            this.btnUpdateBrand.Text = "Update Brand";
            this.btnUpdateBrand.UseVisualStyleBackColor = true;
            this.btnUpdateBrand.Click += new System.EventHandler(this.btnUpdateBrand_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(13, 198);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(116, 36);
            this.btnAddBrand.TabIndex = 11;
            this.btnAddBrand.Text = "Add Brand";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(13, 30);
            this.txtBrandName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBrandName.Multiline = true;
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(116, 43);
            this.txtBrandName.TabIndex = 10;
            // 
            // gridBrand
            // 
            this.gridBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBrand.Location = new System.Drawing.Point(228, 30);
            this.gridBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridBrand.Name = "gridBrand";
            this.gridBrand.Size = new System.Drawing.Size(409, 422);
            this.gridBrand.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1282, 541);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBrands
            // 
            this.btnDeleteBrands.Location = new System.Drawing.Point(17, 286);
            this.btnDeleteBrands.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteBrands.Name = "btnDeleteBrands";
            this.btnDeleteBrands.Size = new System.Drawing.Size(112, 37);
            this.btnDeleteBrands.TabIndex = 7;
            this.btnDeleteBrands.Text = "Delete";
            this.btnDeleteBrands.UseVisualStyleBackColor = true;
            this.btnDeleteBrands.Click += new System.EventHandler(this.btnDeleteBrands_Click);
            // 
            // btnSearchBrand
            // 
            this.btnSearchBrand.Location = new System.Drawing.Point(13, 83);
            this.btnSearchBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchBrand.Name = "btnSearchBrand";
            this.btnSearchBrand.Size = new System.Drawing.Size(116, 36);
            this.btnSearchBrand.TabIndex = 8;
            this.btnSearchBrand.Text = "Search";
            this.btnSearchBrand.UseVisualStyleBackColor = true;
            // 
            // tbBrands
            // 
            this.tbBrands.Location = new System.Drawing.Point(13, 147);
            this.tbBrands.Multiline = true;
            this.tbBrands.Name = "tbBrands";
            this.tbBrands.Size = new System.Drawing.Size(116, 45);
            this.tbBrands.TabIndex = 14;
            this.tbBrands.TextChanged += new System.EventHandler(this.tbBrands_TextChanged);
            // 
            // Brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbBrands);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnUpdateBrand);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.gridBrand);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDeleteBrands);
            this.Controls.Add(this.btnSearchBrand);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Brands";
            this.Size = new System.Drawing.Size(672, 590);
            this.Load += new System.EventHandler(this.Brands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnUpdateBrand;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.DataGridView gridBrand;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDeleteBrands;
        private System.Windows.Forms.Button btnSearchBrand;
        private System.Windows.Forms.TextBox tbBrands;
    }
}
