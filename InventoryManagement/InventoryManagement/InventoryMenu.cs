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
    public partial class InventoryMenu : UserControl
    {
        private static InventoryMenu _instance;
        public static InventoryMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InventoryMenu();
                return _instance;
            }
        }

        public InventoryMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            InventoryManagement.logout();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InventoryManagement.adminLoginButtonClicked();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            InventoryManagement.productBtnClicked();
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            InventoryManagement.catsBtnClicked();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            InventoryManagement.brandsBtnClicked();
        }


    }
}
