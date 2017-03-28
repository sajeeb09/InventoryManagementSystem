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
    public partial class Sales : UserControl
    {
        private static Sales _instance;
        public static Sales Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Sales();
                return _instance;
            }
        }

        inventoryDataContext idc = new inventoryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\09\OneDrive\C#\InventoryManagement\InventoryManagement\inventory_management.mdf;Integrated Security=True");
        private static decimal total = 0;
        private static int id;


        public Sales()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            var proTable = from q in idc.products select q;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(txtQuantity.Text);
            if (gridProductList.SelectedCells[0].Value != null)
            {
                id = Convert.ToInt32(gridProductList.SelectedCells[0].Value.ToString());
                if (quantity > 0)
                {
                    var pro = idc.products.SingleOrDefault(x => x.pro_id == id);
                    decimal price = (decimal) pro.pro_price;
                    int proQtt = (int) pro.pro_quantity;
                    int warranty = (int)pro.pro_warranty;
                    string title = pro.pro_title;
                    int pro_id = pro.pro_id;

                    if(proQtt >= quantity)
                    {
                        total += price * quantity;
                        tbTotal.Text = total.ToString();

                        sale_info current = new sale_info();
                        


                    }
                    else
                    {
                        MessageBox.Show("Insufficient quantity!");
                    }
                }
            }
        }
    }
}
