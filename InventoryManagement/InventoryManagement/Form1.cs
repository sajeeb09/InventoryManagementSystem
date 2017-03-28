using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class InventoryManagement : Form
    {
        private static System.Windows.Forms.Panel panelMenu;
        private static System.Windows.Forms.Panel panelMain;
        
        public InventoryManagement()
        {
            InitializeComponent();
            logout();
        }


        
        //If login Button clicked successfull.
        public static void adminLoginButtonClicked()
        {
            panelMain.Controls.Clear();
            if (!panelMenu.Controls.Contains(Admin.Instance))
            {
                panelMenu.Controls.Clear();
                panelMenu.Controls.Add(Admin.Instance);
                Admin.Instance.Dock = DockStyle.Fill;
                Admin.Instance.BringToFront();
            }
            else
                Admin.Instance.BringToFront();
        }

        
        
        //Load control in panel when the program starts.
        public static void logout()
        {
            if (!panelMenu.Controls.Contains(Login.Instance))
            {
                panelMenu.Controls.Add(Login.Instance);
                Login.Instance.Dock = DockStyle.Fill;
                Login.Instance.BringToFront();
            }
            else
                Login.Instance.BringToFront();

            panelMain.Controls.Clear();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }



        //If Empoyees button clicked.
        public static void empBtnClicked()
        {
            if (!panelMain.Controls.Contains(Employees.Instance))
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(Employees.Instance);
                Employees.Instance.Dock = DockStyle.Fill;
                Employees.Instance.BringToFront();
            }
            else
                Employees.Instance.BringToFront();
        }



        //Inventory button clicked in admin menu.
        public static void inventoryButtonClicked()
        {
            panelMain.Controls.Clear();
            if (!panelMenu.Controls.Contains(InventoryMenu.Instance))
            {
                panelMenu.Controls.Add(InventoryMenu.Instance);
                InventoryMenu.Instance.Dock = DockStyle.Fill;
                InventoryMenu.Instance.BringToFront();
            }
            else
                InventoryMenu.Instance.BringToFront();
        }



        //Add employy button clicked
        public static void addEmp()
        {
            if (!panelMain.Controls.Contains(addEmployee.Instance))
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(addEmployee.Instance);
                addEmployee.Instance.Dock = DockStyle.Fill;
                addEmployee.Instance.BringToFront();
            }
            else
                addEmployee.Instance.BringToFront();
        }


        //Product button clicked.
        public static void productBtnClicked()
        {
            if (!panelMain.Controls.Contains(products.Instance))
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(products.Instance);
                products.Instance.Dock = DockStyle.Fill;
                products.Instance.BringToFront();
            }
            else
                products.Instance.BringToFront();
        }


        //Product button clicked.
        public static void catsBtnClicked()
        {
            if (!panelMain.Controls.Contains(Category.Instance))
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(Category.Instance);
                Category.Instance.Dock = DockStyle.Fill;
                Category.Instance.BringToFront();
            }
            else
                Category.Instance.BringToFront();
        }



        //Brand button clicked.
        public static void brandsBtnClicked()
        {
            if (!panelMain.Controls.Contains(Brands.Instance))
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(Brands.Instance);
                Brands.Instance.Dock = DockStyle.Fill;
                Brands.Instance.BringToFront();
            }
            else
                Brands.Instance.BringToFront();
        }



        //Add product.
        public static void addPro()
        {
            if (!panelMain.Controls.Contains(addProduct.Instance))
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(addProduct.Instance);
                addProduct.Instance.Dock = DockStyle.Fill;
                addProduct.Instance.BringToFront();
            }
            else
                addProduct.Instance.BringToFront();
        }



        //Update Employees.
        public static void updateEmp()
        {
            if (!panelMain.Controls.Contains(UserProfile.Instance))
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(UserProfile.Instance);
                UserProfile.Instance.Dock = DockStyle.Fill;
                UserProfile.Instance.BringToFront();
            }
            else
                UserProfile.Instance.BringToFront();
        }



        //Update Product.
        public static void updatePro()
        {
            if (!panelMain.Controls.Contains(edit_product.Instance))
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(edit_product.Instance);
                edit_product.Instance.Dock = DockStyle.Fill;
                edit_product.Instance.BringToFront();
            }
            else
                edit_product.Instance.BringToFront();
        }


        //Login User.
        public static void UserBtnClicked()
        {
            if (!panelMenu.Controls.Contains(UserMenu.Instance))
            {
                panelMenu.Controls.Add(UserMenu.Instance);
                UserMenu.Instance.Dock = DockStyle.Fill;
                UserMenu.Instance.BringToFront();
            }
            else
                UserMenu.Instance.BringToFront();

            if (!panelMain.Controls.Contains(Sales.Instance))
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(Sales.Instance);
                Sales.Instance.Dock = DockStyle.Fill;
                Sales.Instance.BringToFront();
            }
            else
                Sales.Instance.BringToFront();
        }
    }
}
