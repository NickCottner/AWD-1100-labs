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
    public partial class frmProductVendors : Form
    {
        public frmProductVendors()
        {
            InitializeComponent();
        }

        private void productVendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productVendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salesOrdersDataSet);

        }

        private void frmProductVendors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesOrdersDataSet.ProductVendors' table. You can move, or remove it, as needed.
            this.productVendorsTableAdapter.Fill(this.salesOrdersDataSet.ProductVendors);
            

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

        private void btnVendors_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalMethods.GoToVendors();
        }

        private void fillByProductIDAndVendorIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productVendorsTableAdapter.FillByProductIDAndVendorID(this.salesOrdersDataSet.ProductVendors, ((int)(System.Convert.ChangeType(productIDToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(vendorIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
