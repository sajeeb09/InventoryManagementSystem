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
    public partial class UserProfile : UserControl
    {

        inventoryDataContext idc = new inventoryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\09\OneDrive\C#\InventoryManagement\InventoryManagement\inventory_management.mdf;Integrated Security=True");
        employee emp = new employee();


        private string name = "";
        private string phone = "";
        private string gender = "";
        private string email = "";
        private string address = "";
        private string nid = "";
        private string rank = "";
        private decimal sal = 0.0m;


        private static UserProfile _instance;
        public static UserProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserProfile();
                return _instance;
            }
        }
        
        public UserProfile()
        {
            InitializeComponent();
            int id = Employees.ID;
            emp = idc.employees.SingleOrDefault(x => x.emp_id == id);

            tbAddress.Text = emp.emp_address;
            tbMail.Text = emp.emp_email;
            tbName.Text = emp.emp_name;
            tbNid.Text = emp.emp_nid;
            tbPhone.Text = emp.emp_phone;
            tbRank.Text = emp.emp_rank;
            tbSal.Text = emp.emp_sal.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NID_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            name = tbName.Text.ToString();
            rank = tbRank.Text.ToString();
            phone = tbPhone.Text.ToString();
            email = tbMail.Text.ToString();
            address = tbAddress.Text.ToString();
            nid = tbNid.Text.ToString();
            sal = Convert.ToDecimal(tbSal.Text.ToString());
            gender = cbGender.SelectedItem.ToString();

            if (!name.Equals("") && !rank.Equals("") && !phone.Equals("") && !email.Equals("") && !address.Equals("") &&
                !nid.Equals("") && !gender.Equals("") && sal > 0)
            {
                emp.emp_address = address;
                emp.emp_email = email;
                emp.emp_gender = gender;
                emp.emp_name = name;
                emp.emp_nid = nid;
                emp.emp_phone = phone;
                emp.emp_sal = sal;
                emp.emp_rank = rank;

                idc.SubmitChanges();
                MessageBox.Show("Successfully updated an employee.");
            }
            else
            {
                lblError.Text = "Please select a row to delete.";
            }
        }
    }
}
