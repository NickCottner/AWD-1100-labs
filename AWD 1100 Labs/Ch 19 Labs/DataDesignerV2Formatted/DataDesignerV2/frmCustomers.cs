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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salesOrdersDataSet);

        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesOrdersDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.salesOrdersDataSet.States);
            // TODO: This line of code loads data into the 'salesOrdersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.salesOrdersDataSet.Customers);

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

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByCustomerID(this.salesOrdersDataSet.Customers, ((int)(System.Convert.ChangeType(customerIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
