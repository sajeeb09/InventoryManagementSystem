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
    public partial class products : UserControl
    {
        inventoryDataContext idc = new inventoryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\09\OneDrive\C#\InventoryManagement\InventoryManagement\inventory_management.mdf;Integrated Security=True");
        
        private static products _instance;
        public static products Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new products();
                return _instance;
            }
        }

        private static int id = 0;
        public static int ID
        {
            get
            {
                return id;
            }
        }
        
        
        public products()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void gridBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            InventoryManagement.addPro();
        }

        private void products_Load(object sender, EventArgs e)
        {
            var proTable = from q in idc.products select q;

            gridProducts.DataSource = proTable;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (gridProducts.SelectedCells[0].Value != null)
            {
                id = Convert.ToInt32(gridProducts.SelectedCells[0].Value.ToString());
                InventoryManagement.updatePro();
            }
            else
            {
                lblError.Text = "Select a product first.";
            }
        }
    }
}
