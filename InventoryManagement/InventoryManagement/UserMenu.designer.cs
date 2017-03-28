namespace InventoryManagement
{
    partial class UserMenu
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
            this.btnUEdit = new System.Windows.Forms.Button();
            this.btnUchngpass = new System.Windows.Forms.Button();
            this.btnUlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUEdit
            // 
            this.btnUEdit.BackColor = System.Drawing.Color.Lime;
            this.btnUEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUEdit.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUEdit.Location = new System.Drawing.Point(6, 6);
            this.btnUEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnUEdit.Name = "btnUEdit";
            this.btnUEdit.Size = new System.Drawing.Size(176, 46);
            this.btnUEdit.TabIndex = 0;
            this.btnUEdit.Text = "Edit Profile";
            this.btnUEdit.UseVisualStyleBackColor = false;
            this.btnUEdit.Click += new System.EventHandler(this.btnUEdit_Click);
            // 
            // btnUchngpass
            // 
            this.btnUchngpass.BackColor = System.Drawing.Color.Lime;
            this.btnUchngpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUchngpass.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUchngpass.Location = new System.Drawing.Point(6, 51);
            this.btnUchngpass.Margin = new System.Windows.Forms.Padding(6);
            this.btnUchngpass.Name = "btnUchngpass";
            this.btnUchngpass.Size = new System.Drawing.Size(176, 46);
            this.btnUchngpass.TabIndex = 1;
            this.btnUchngpass.Text = "Change Password";
            this.btnUchngpass.UseVisualStyleBackColor = false;
            this.btnUchngpass.Click += new System.EventHandler(this.btnUchngpass_Click);
            // 
            // btnUlogout
            // 
            this.btnUlogout.BackColor = System.Drawing.Color.Red;
            this.btnUlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUlogout.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUlogout.Location = new System.Drawing.Point(6, 95);
            this.btnUlogout.Name = "btnUlogout";
            this.btnUlogout.Size = new System.Drawing.Size(176, 44);
            this.btnUlogout.TabIndex = 2;
            this.btnUlogout.Text = "LogOut";
            this.btnUlogout.UseVisualStyleBackColor = false;
            this.btnUlogout.Click += new System.EventHandler(this.btnUlogout_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnUlogout);
            this.Controls.Add(this.btnUchngpass);
            this.Controls.Add(this.btnUEdit);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserMenu";
            this.Size = new System.Drawing.Size(188, 363);
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUEdit;
        private System.Windows.Forms.Button btnUchngpass;
        private System.Windows.Forms.Button btnUlogout;
    }
}
