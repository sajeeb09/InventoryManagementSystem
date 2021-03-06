﻿using System;
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

    public partial class addProduct : UserControl
    {
        inventoryDataContext idc = new inventoryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\09\OneDrive\C#\InventoryManagement\InventoryManagement\inventory_management.mdf;Integrated Security=True");
        private static addProduct _instance;
        public static addProduct Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new addProduct();
                return _instance;
            }
        }


        private string name = "";
        private string brand = "";
        private string cat = "";
        private decimal price = 0.0m;
        private int warranty = 0;
        private int quantity = 0;


        public addProduct()
        {
            InitializeComponent();
            var cat = (from q in idc.categories select q.cat_title).ToList();
            cbCat.DataSource = cat;

            var brand = (from q in idc.brands select q.brand_title).ToList();
            cbBrand.DataSource = brand;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            name = txtProductName.Text.ToString();
            brand = cbBrand.SelectedItem.ToString();
            cat = cbCat.SelectedItem.ToString();
            price = Convert.ToDecimal(txtProductPrice.Text.ToString());
            warranty = Convert.ToInt32(txtProductWarrenty.Text.ToString());
            quantity = Convert.ToInt32(txtProductQuantity.Text.ToString());

            product pr = new product();
            pr.pro_brand = brand;
            pr.Pro_cat = cat;
            pr.pro_price = price;
            pr.pro_quantity = quantity;
            pr.pro_title = name;
            pr.pro_warranty = warranty;

            if (!name.Equals("") && !brand.Equals("") && !cat.Equals("") && !price.Equals("") && !quantity.Equals("") &&
                !warranty.Equals(""))
            {
                idc.products.InsertOnSubmit(pr);
                idc.SubmitChanges();
                MessageBox.Show("Successfully Added an product.");
            }
            else
            {
                lblError.Text = "Please fill all the fields.";
            }

        }

        private void btnCacel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                InventoryManagement.productBtnClicked();
            }
        }
    }
}
