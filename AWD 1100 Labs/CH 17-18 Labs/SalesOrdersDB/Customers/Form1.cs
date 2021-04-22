using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Customers
{
    public partial class FormSalesOrders : Form
    {
        // Create database variables
        SqlConnection conn;
        SqlCommand customersCommand;
        SqlDataAdapter customersAdapter;
        DataTable customersTable;
        CurrencyManager customersCurrencyManager;

        public FormSalesOrders()
        {
            InitializeComponent();
        }

        private void FormSalesOrders_Load(object sender, EventArgs e)
        {
            var connString = @"Server=DESKTOP-D16ANB0\SQLEXPRESS;Database=salesOrders;Integrated Security=SSPI";

            conn = new SqlConnection(connString);

            conn.Open();

            customersCommand = new SqlCommand("SELECT * FROM customers", conn);

            customersAdapter = new SqlDataAdapter(customersCommand);

            customersTable = new DataTable();

            customersAdapter.Fill(customersTable);

            //Bind Associated Controls
            txtFirstName.DataBindings.Add("Text", customersTable, "customerFirstName");
            txtLastName.DataBindings.Add("Text", customersTable, "customerLastName");
            txtStreetAddress.DataBindings.Add("Text", customersTable, "customerStreetAddress");
            txtCity.DataBindings.Add("Text", customersTable, "customerCity");
            txtState.DataBindings.Add("Text", customersTable, "customerState");
            txtZipCode.DataBindings.Add("Text", customersTable, "customerZipCode");
            txtAreaCode.DataBindings.Add("Text", customersTable, "customerAreaCode".ToString());
            txtPhoneNumber.DataBindings.Add("Text", customersTable, "customerPhoneNumber");

            //EstablishCurrencyManager
            customersCurrencyManager = (CurrencyManager)BindingContext[customersTable];

            customersAdapter.Dispose();
            customersTable.Dispose();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            customersCurrencyManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            customersCurrencyManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            customersCurrencyManager.Position++;
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            customersCurrencyManager.Position = customersCurrencyManager.Count - 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Exit?", "EXIT NOW?",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                conn.Close();
                Application.Exit();
            }
        }
    }
}