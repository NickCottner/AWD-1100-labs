using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataDesignerV2
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToCustomers();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToEmployees();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToCategories();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToOrders();
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToOrderDetails();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToProducts();
        }

        private void btnProductVendors_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToProductVendors();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToVendors();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.ExitApplication();
        }

       
    }
}
