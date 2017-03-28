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
    public partial class Brands : UserControl
    {
        inventoryDataContext idc = new inventoryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\09\OneDrive\C#\InventoryManagement\InventoryManagement\inventory_management.mdf;Integrated Security=True");

        private string name = "";

        private static Brands _instance;
        public static Brands Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Brands();
                return _instance;
            }
        }
        
        public void refresh()
        {
            txtBrandName.Text = "";
            lblError.Text = "";
        }
        
        public Brands()
        {
            InitializeComponent();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            name = tbBrands.Text.ToString();

            brand b = new brand();
            b.brand_title = name;

            if (!name.Equals("") )
            {
                idc.brands.InsertOnSubmit(b);
                idc.SubmitChanges();
                MessageBox.Show("Successfully Added a brand.");
            }
            else
            {
                lblError.Text = "Please fill all the fields.";
            }
        }

        private void tbBrands_TextChanged(object sender, EventArgs e)
        {

        }

        private void Brands_Load(object sender, EventArgs e)
        {
            var proTable = from q in idc.brands select q;

            gridBrand.DataSource = proTable;
        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            if (gridBrand.SelectedCells[0].Value != null)
            {
                if(!tbBrands.Text.Equals(""))
                {
                    int id = Convert.ToInt32(gridBrand.SelectedCells[0].Value.ToString());

                    brand br = idc.brands.SingleOrDefault(x => x.brand_id == id);

                    br.brand_title = tbBrands.Text;

                    idc.SubmitChanges();
                    MessageBox.Show("Successfully updated a brand.");
                }
                else
                {
                    lblError.Text = "Enter a name to proceed.";
                }
            }
            else
            {
                lblError.Text = "Please select a row to update.";
            }
        }

        private void btnDeleteBrands_Click(object sender, EventArgs e)
        {
            if (gridBrand.SelectedCells[0].Value != null)
            {
                
                    int id = Convert.ToInt32(gridBrand.SelectedCells[0].Value.ToString());

                    brand br = idc.brands.SingleOrDefault(x => x.brand_id == id);

                    idc.brands.DeleteOnSubmit(br);
                    idc.SubmitChanges();
                    MessageBox.Show("Successfully deleted a brand.");
            }
            else
            {
                lblError.Text = "Please select a row to delete.";
            }
        }
    }
}
