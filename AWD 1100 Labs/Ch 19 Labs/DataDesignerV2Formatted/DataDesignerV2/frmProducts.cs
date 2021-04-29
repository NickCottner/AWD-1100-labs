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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salesOrdersDataSet);

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesOrdersDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.salesOrdersDataSet.Products);

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToCustomers();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToCategories();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToEmployees();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToHome();
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

        private void fillByProductIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByProductID(this.salesOrdersDataSet.Products, ((int)(System.Convert.ChangeType(productIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
