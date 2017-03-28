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
    public partial class Employees : UserControl
    {

        inventoryDataContext idc = new inventoryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\09\OneDrive\C#\InventoryManagement\InventoryManagement\inventory_management.mdf;Integrated Security=True");
        private static int id = 0;

        public static int ID
        {
            get
            {
                return id;
            }
        }

        private static Employees _instance;
        public static Employees Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Employees();
                return _instance;
            }
        }
        
        public Employees()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            InventoryManagement.addEmp();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            //employee emp = new employee();

            var empTable = from q in idc.employees select q;

            gvEmp.DataSource = empTable;
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            if (gvEmp.SelectedCells[0].Value != null)
            {
                int id = Convert.ToInt32(gvEmp.SelectedCells[0].Value.ToString());

                employee emp = idc.employees.SingleOrDefault(x => x.emp_id == id);

                idc.employees.DeleteOnSubmit(emp);
                idc.SubmitChanges();
                MessageBox.Show("Successfully deleted an employee.");
            }
            else
            {
                lblErrorEmp.Text = "Please select a row to delete.";
            }
        }

        private void gvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefreshEmp_Click(object sender, EventArgs e)
        {
            lblErrorEmp.Text = "";
            var empTable = from q in idc.employees select q;
            gvEmp.DataSource = empTable;
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (gvEmp.SelectedCells[0].Value != null) 
            {
                id = Convert.ToInt32(gvEmp.SelectedCells[0].Value.ToString());
                InventoryManagement.updateEmp();
            }
        }
    }
}
