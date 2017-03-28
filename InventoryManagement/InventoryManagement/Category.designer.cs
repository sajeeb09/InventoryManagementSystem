namespace InventoryManagement
{
    partial class Category
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
            this.btnSearchCat = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gridCategory = new System.Windows.Forms.DataGridView();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnUpdateCat = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tbCat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchCat
            // 
            this.btnSearchCat.Location = new System.Drawing.Point(25, 99);
            this.btnSearchCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchCat.Name = "btnSearchCat";
            this.btnSearchCat.Size = new System.Drawing.Size(133, 39);
            this.btnSearchCat.TabIndex = 0;
            this.btnSearchCat.Text = "Search";
            this.btnSearchCat.UseVisualStyleBackColor = true;
            this.btnSearchCat.Click += new System.EventHandler(this.btnSearchCat_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(25, 298);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(133, 37);
            this.btnDeleteCategory.TabIndex = 0;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1286, 528);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 37);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gridCategory
            // 
            this.gridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategory.Location = new System.Drawing.Point(235, 37);
            this.gridCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridCategory.Name = "gridCategory";
            this.gridCategory.Size = new System.Drawing.Size(443, 411);
            this.gridCategory.TabIndex = 1;
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(25, 37);
            this.txtCatName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCatName.Multiline = true;
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(133, 43);
            this.txtCatName.TabIndex = 2;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(25, 212);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(133, 36);
            this.btnAddCat.TabIndex = 3;
            this.btnAddCat.Text = "Add Category";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnUpdateCat
            // 
            this.btnUpdateCat.Location = new System.Drawing.Point(25, 254);
            this.btnUpdateCat.Name = "btnUpdateCat";
            this.btnUpdateCat.Size = new System.Drawing.Size(133, 36);
            this.btnUpdateCat.TabIndex = 4;
            this.btnUpdateCat.Text = "Update Category";
            this.btnUpdateCat.UseVisualStyleBackColor = true;
            this.btnUpdateCat.Click += new System.EventHandler(this.btnUpdateCat_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(20, 389);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 5;
            this.lblError.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCat
            // 
            this.tbCat.Location = new System.Drawing.Point(25, 146);
            this.tbCat.Multiline = true;
            this.tbCat.Name = "tbCat";
            this.tbCat.Size = new System.Drawing.Size(133, 47);
            this.tbCat.TabIndex = 6;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbCat);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnUpdateCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.gridCategory);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnSearchCat);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Category";
            this.Size = new System.Drawing.Size(769, 590);
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCat;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView gridCategory;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnUpdateCat;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox tbCat;
    }
}
