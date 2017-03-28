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
    public partial class Admin : UserControl
    {
        private static Admin _instance;
        public static Admin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Admin();
                return _instance;
            }
        }
        
        public Admin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            InventoryManagement.logout();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            InventoryManagement.empBtnClicked();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryManagement.inventoryButtonClicked();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
