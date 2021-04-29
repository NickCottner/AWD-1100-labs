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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salesOrdersDataSet);

        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesOrdersDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.salesOrdersDataSet.Orders);

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

        private void fillByOrderId1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.FillByOrderId1(this.salesOrdersDataSet.Orders, ((int)(System.Convert.ChangeType(orderIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
