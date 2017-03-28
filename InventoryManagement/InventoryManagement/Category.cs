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
    public partial class Category : UserControl
    {
        inventoryDataContext idc = new inventoryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\09\OneDrive\C#\InventoryManagement\InventoryManagement\inventory_management.mdf;Integrated Security=True");

        private string name = "";

        private static Category _instance;
        public static Category Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Category();
                return _instance;
            }
        }
        
        
        public Category()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void refresh()
        {
            txtCatName.Text = "";
            lblError.Text = "";
        }
        

        private void btnSearchCat_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            name = tbCat.Text.ToString();

            category c = new category();
            c.cat_title = name;

            if (!name.Equals("") )
            {
                idc.categories.InsertOnSubmit(c);
                idc.SubmitChanges();
                MessageBox.Show("Successfully Added a category.");
            }
            else
            {
                lblError.Text = "Please fill all the fields.";
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            var proTable = from q in idc.categories select q;

            gridCategory.DataSource = proTable;
        }

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            if (gridCategory.SelectedCells[0].Value != null)
            {
                if (!tbCat.Text.Equals(""))
                {
                    int id = Convert.ToInt32(gridCategory.SelectedCells[0].Value.ToString());

                    category br = idc.categories.SingleOrDefault(x => x.cat_id == id);

                    br.cat_title = tbCat.Text;

                    idc.SubmitChanges();
                    MessageBox.Show("Successfully updated a category.");
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

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (gridCategory.SelectedCells[0].Value != null)
            {

                int id = Convert.ToInt32(gridCategory.SelectedCells[0].Value.ToString());

                category br = idc.categories.SingleOrDefault(x => x.cat_id == id);

                idc.categories.DeleteOnSubmit(br);
                idc.SubmitChanges();
                MessageBox.Show("Successfully deleted a category.");
            }
            else
            {
                lblError.Text = "Please select a row to delete.";
            }
        }
        }
    
}
