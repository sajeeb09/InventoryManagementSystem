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
    public partial class edit_product : UserControl
    {
        inventoryDataContext idc = new inventoryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\09\OneDrive\C#\InventoryManagement\InventoryManagement\inventory_management.mdf;Integrated Security=True");
        product pr = new product();

        private static edit_product _instance;
        public static edit_product Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new edit_product();
                return _instance;
            }
        }
        public edit_product()
        {
            InitializeComponent();
            var cat = (from q in idc.categories select q.cat_title).ToList();
            cbCat.DataSource = cat;

            var brand = (from q in idc.brands select q.brand_title).ToList();
            cbBrand.DataSource = brand;

            int id = products.ID;
            pr = idc.products.SingleOrDefault(x => x.pro_id == id);

            txtName.Text = pr.pro_title;
            txtProductPrice.Text = pr.pro_price.ToString();
            txtProductQuantity.Text = pr.pro_quantity.ToString();
            txtProductWarrenty.Text = pr.pro_warranty.ToString();
        }

        private string name = "";
        private string brand = "";
        private string cat = "";
        private decimal price = 0.0m;
        private int warranty = 0;
        private int quantity = 0;

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            name = txtName.Text.ToString();
            brand = cbBrand.SelectedItem.ToString();
            cat = cbCat.SelectedItem.ToString();
            price = Convert.ToDecimal(txtProductPrice.Text.ToString());
            warranty = Convert.ToInt32(txtProductWarrenty.Text.ToString());
            quantity = Convert.ToInt32(txtProductQuantity.Text.ToString());
            

            if (!name.Equals("") && !brand.Equals("") && !cat.Equals("") && !price.Equals("") && !quantity.Equals("") &&
                !warranty.Equals(""))
            {
                pr.pro_brand = brand;
                pr.Pro_cat = cat;
                pr.pro_price = price;
                pr.pro_quantity = quantity;
                pr.pro_title = name;
                pr.pro_warranty = warranty;

                idc.SubmitChanges();
                MessageBox.Show("Successfully Added an product.");
            }
            else
            {
                lblError.Text = "Please fill all the fields.";
            }
        }
    }
}
