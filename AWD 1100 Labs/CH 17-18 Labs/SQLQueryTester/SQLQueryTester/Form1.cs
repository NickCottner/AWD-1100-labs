using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SQLQueryTester
{
    public partial class FrmSQLQueryTester : Form
    {
        SqlConnection conn;
        SqlCommand queryCommand;
        SqlDataAdapter queryAdapter;
        DataTable table;
        public FrmSQLQueryTester()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            queryCommand = null;
            queryAdapter = new SqlDataAdapter();
                   table = new DataTable();

            try
            {
                queryCommand = new SqlCommand(txtQuery.Text, conn);
                queryAdapter.SelectCommand = queryCommand;
                queryAdapter.Fill(table);

                dgvQueryTester.DataSource = table;
                lblNumOfRecords.Text = table.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("SQL Error!\r\n" + ex.Message, "ERROR IN SQL!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            this.dgvQueryTester.DataSource = null;
            this.dgvQueryTester.Rows.Clear();

            txtQuery.Text = "";
            lblNumOfRecords.Text = "0";
            txtQuery.Focus();
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

        private void FrmSQLQueryTester_Load(object sender, EventArgs e)
        {
            var connString = @"Server=DESKTOP-D16ANB0\SQLEXPRESS;Database=salesOrders;Integrated Security=SSPI";

            conn = new SqlConnection(connString);

            conn.Open();
        }
    }
}
