using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeSalesGUI
{
    public partial class FormHomeSales : Form
    {
        public FormHomeSales()
        {
            InitializeComponent();
        }
        double salesDanielle = 0;
        double salesEdward = 0;
        double salesFrancis = 0;
        double amountSale = 0;
        double grandTotal = 0;

        private void textBoxcostOfSale_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void buttonDanielle_Click(object sender, EventArgs e)
        {
            salesDanielle = Convert.ToDouble(textBoxcostOfSale.Text);
            amountSale = salesDanielle;
        }

        private void buttonEdward_Click(object sender, EventArgs e)
        {
            salesEdward = Convert.ToDouble(textBoxcostOfSale.Text);
            amountSale = salesEdward;
        }

        private void buttonFrancis_Click(object sender, EventArgs e)
        {
            salesFrancis = Convert.ToDouble(textBoxcostOfSale.Text);
            amountSale = salesFrancis;
        }
        
        private void textBoxSales_TextChanged(object sender, EventArgs e)
        {
            textBoxSales.Text = "Danielle Sales: " + amountSale + "\nEdward Sales: 0 " + amountSale +
                                "\nFrancis Sales: " + amountSale + "\n\nGrand Total: " + grandTotal;
        }
    }
}
