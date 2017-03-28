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
    public partial class UserMenu : UserControl
    {
        private static UserMenu _instance;
        public static UserMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserMenu();
                return _instance;
            }
        }
        
        
        public UserMenu()
        {
            InitializeComponent();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnUlogout_Click(object sender, EventArgs e)
        {

        }

        private void btnUchngpass_Click(object sender, EventArgs e)
        {

        }

        private void btnUEdit_Click(object sender, EventArgs e)
        {
            InventoryManagement.updateEmp();
        }
    }
}
