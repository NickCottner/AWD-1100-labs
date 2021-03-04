using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCarefreeResort
{
    public partial class FormCarefreeResort : Form
    {
        public FormCarefreeResort()
        {
            InitializeComponent();
        }
        string[] nightsStayed = {"1, 2, 3, 4, 5, 6, 7, 8, 9, 10"};

        decimal[] nightlyCost = {200.0m, 200.0m, 180.0m, 180.0m ,160.0m, 160.0m, 160.0m, 145.0m, 145.0m, 145.0m};

        decimal[] totalCost = { 200.0m, 400.0m, 540.0m, 720.0m, 800.0m, 960.0m, 1120.0m, 1160.0m, 1305.0m, 1450.0m };

        int index = -1;

        

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
           bool keepGoing =  calculateCostofStay();
            if (keepGoing)
            {
                showCost();
            }
            else
            {
                return;
            }
        }
        private bool calculateCostofStay()
        {
            index = -1;
            bool retVal = false;
            string item = "";
            if (textBoxNightsStayed.Text.Trim() == "")
            {
                MessageBox.Show("No Nights Stayed Entered", "NO NIGHTS STAYED ENTERED!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNightsStayed.Focus();
            }
            else
            {
                item = textBoxNightsStayed.Text.ToLower();
                for (int lcv = 0; lcv < nightsStayed.Length; ++lcv)
                {
                    if (nightsStayed[lcv].Contains(item))
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
        private void showCost()
        {

            
            labelTheNightlyCost.Text = nightlyCost[index].ToString("c");
            labelTheTotalCost.Text = totalCost[index].ToString("c");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }
        private void clearAndSetFocus()
        {
            textBoxNightsStayed.Text = "";
            labelTheNightlyCost.Text = "";
            labelTheTotalCost.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            exitApplication();
        }
        private void exitApplication()
        {
            if (MessageBox.Show("Do You Really Want To Exit?", "EXIT PROGRAM?",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                                         == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        

    }
}
