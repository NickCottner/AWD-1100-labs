using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataDesignerV2
{
    public static class GlobalMethods
    {
        static public void ExitApplication()
        {
            System.Windows.Forms.DialogResult dialog = MessageBox.Show(
                           "Do You Really Want To Exit?",
                           "EXIT NOW?",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        static public void GoToHome()
        {
            frmHome home = new frmHome();
            home.ShowDialog();
        }

        static public void GoToCustomers()
        {
            frmCustomers customers = new frmCustomers();
            customers.ShowDialog();
        }

        static public void GoToEmployees()
        {
            frmEmployees employees = new frmEmployees();
            employees.ShowDialog();
        }

        static public void GoToOrders()
        {
            frmOrders orders = new frmOrders();
            orders.ShowDialog();
        }
        static public void GoToOrderDetails()
        {
            frmOrderDetails orderDetails = new frmOrderDetails();
            orderDetails.ShowDialog();
        }

        static public void GoToCategories()
        {
            frmCategories categories = new frmCategories();
            categories.ShowDialog();
        }

        static public void GoToProducts()
        {
            frmProducts products = new frmProducts();
            products.ShowDialog();
        }

        static public void GoToProductVendors()
        {
            frmProductVendors productVendors = new frmProductVendors();
            productVendors.ShowDialog();
        }

        static public void GoToVendors()
        {
            frmVendors vendors = new frmVendors();
            vendors.ShowDialog();
        }
    }
}
