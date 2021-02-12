using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryCharge
{
    public partial class FormDeliveryCharge : Form
    {
        public FormDeliveryCharge()
        {
            InitializeComponent();
        }
        const int LEN = 10;


        string[] zipCode = {"63101", "63103", "63105" , "63109", "63113",
                            "63118", "63130", "63133", "63136", "63137"};

        decimal[] deliveryCharge = {20.00m, 12.00m, 25.00m, 15.00m, 10.00m, 23.00m,
                                    18.00m, 20.00m, 17.00m, 12.00m};

        int index = -1;

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = doesChargeExist();

            if (keepGoing)
            {
                showCharge();
            }
            else
            {
                return;
            }
        }

        private bool doesChargeExist()
        {
            index = -1;
            bool retVal = false;
            string item = "";

            if (textBoxZipcode.Text.Trim() == "")
            {
                MessageBox.Show("No Zipcode Entered", "NO ZIPCODE ENTERED!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxZipcode.Focus();
            }
            else
            {
                item = textBoxZipcode.Text.ToLower();
                for (int lcv = 0; lcv < zipCode.Length; ++lcv)
                {
                    if (zipCode[lcv].ToLower().Contains(item))
                    {
                        retVal = true;
                        index = lcv;
                        break;
                    }
                    else
                    {
                        retVal = false;
                        index = -1;
                    }
                }
            }
            return retVal;
        }
        private void showCharge()
        {
            labelPrice.Text = deliveryCharge[index].ToString("c");
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }
        private void clearAndSetFocus()
        {
            textBoxZipcode.Text = "";
            labelPrice.Text = "";
        }
    }
}
