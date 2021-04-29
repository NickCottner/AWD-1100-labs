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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salesOrdersDataSet);

        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesOrdersDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.salesOrdersDataSet.Products);
            // TODO: This line of code loads data into the 'salesOrdersDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.salesOrdersDataSet.Categories);
            // TODO: This line of code loads data into the 'salesOrdersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.salesOrdersDataSet.Customers);

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToHome();
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

        private void fillByCategoryIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriesTableAdapter.FillByCategoryID(this.salesOrdersDataSet.Categories, ((int)(System.Convert.ChangeType(categoryIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
