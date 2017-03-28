using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class addEmployee : UserControl
    {

        private static addEmployee _instance;
        public static addEmployee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new addEmployee();
                return _instance;
            }
        }


        inventoryDataContext idc = new inventoryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\09\OneDrive\C#\InventoryManagement\InventoryManagement\inventory_management.mdf;Integrated Security=True");
        private string name = "";
        private string phone = "";
        private string gender = "";
        private string email = "";
        private string address = "";
        private string nid = "";
        private string rank = "";
        private string join = "";
        private string DOB = "";
        private decimal sal = 0.0m;
        
        
        public addEmployee()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPresentAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpContactNo_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelEmp_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                InventoryManagement.empBtnClicked();
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            name = tbEmpName.Text.ToString();
            rank = tbEmpRank.Text.ToString();
            phone = tbEmpPhone.Text.ToString();
            email = tbEmpMail.Text.ToString();
            address = tbEmpAddress.Text.ToString();
            nid = tbEmpNID.Text.ToString();
            sal = Convert.ToDecimal(tbEmpSal.Text.ToString());
            gender = cbGender.SelectedItem.ToString();
            join = dtpJoin.Value.ToString("yyyy-MM-dd");
            DOB = dtpDOB.Value.ToString("yyyy-MM-dd");
            
            
            employee emp = new employee();


            emp.emp_address = address;
            emp.emp_dob = Convert.ToDateTime(DOB);
            emp.emp_email = email;
            emp.emp_gender = gender;
            emp.emp_join_date = Convert.ToDateTime(join);
            emp.emp_name = name;
            emp.emp_nid = nid;
            emp.emp_phone = phone;
            emp.emp_sal = sal;
            emp.emp_rank = rank;


            if(!name.Equals("") && !rank.Equals("") && !phone.Equals("") && !email.Equals("") && !address.Equals("") && 
                !nid.Equals("") && !gender.Equals("") && sal > 0)
            {
                idc.employees.InsertOnSubmit(emp);
                idc.SubmitChanges();
                MessageBox.Show("Successfully Added an employee.");
            }
            else
            {
                lblError.Text = "Please fill all the fields.";
            }
        }
    }
}
