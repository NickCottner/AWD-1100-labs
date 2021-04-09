using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harold_sHomeServices
{
    public partial class FormHaroldsHomeServices : Form
    {
        public FormHaroldsHomeServices()
        {
            InitializeComponent();
        }
        
        //Global Constants
        const int MAXLEN = 5;
        const double TRIP_FEE = 35;

        //Global Variables
        string[] jobs = new string[MAXLEN];
        string job = "";
        double[] hoursToComplete = new double[MAXLEN];
        double[] hourlyRate = new double[MAXLEN];
        double HTC = 0;
        double HR = 0;
        int curNumOfJobs = 0;
        double totalFee = 0;


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            double result;

            //Validating non-empty description
            if (keepGoing)
            {
                keepGoing = validateDescription();
            }

            //If true, description was not empty
            if (keepGoing)
            {
                //Validate hoursToComplete was: 
                // 1) Not blank
                // 2) Numeric
                // 3) > 0;
                keepGoing = validateHoursToComplete(out result);
            }
            else
            {
                //Description was empty
                return;
            }
            if (keepGoing)
            {
                //Validate hourlyRate was:
                // 1) Not blank
                // 2) Numeric
                // 3) > 0;
                keepGoing = validateHourlyRate(out result);
            }
            else
            {
                // hoursToComplete Was Empty
                return;
            }

            if (keepGoing)
            {
                //Checking for filled job descriptions
                if (curNumOfJobs >= MAXLEN)
                {
                    showMessageBox("Attempted To Enter Into Already Full Job Descripions List",
                                   "DESCRIPTIONS FILLED - CANNOT ENTER ANY MORE DESCRIPTIONS!");
                    return;
                }
                else
                {
                    // List not full. Add the current description to the associated
                    // hoursToComplete and hourlyRate arrays.
                    calculateTotalFee();
                    printCurrentResults();
                }
            }
        }

        //Validate description was not empty
        private bool validateDescription()
        {
            if (textBoxDescription.Text.Trim() == "")
            {
                showMessageBox("Description Cannot Be Blank.", "BLANK DESCRIPTION!");
                textBoxDescription.Focus();
                return false;
            }

            job = textBoxDescription.Text;
            return true;
            
        }
        //Validate hoursToComplete
        private bool validateHoursToComplete(out double result)
        {
            if (textBoxHoursToComplete.Text.Trim() == "")
            {
                showMessageBox("Hours To Complete Cannot Be Blank.", "HOURS TO COMPLETE IS BLANK!");
                textBoxHoursToComplete.Focus();
                result = -1;
                return false;
            }

            bool res = Double.TryParse(textBoxHoursToComplete.Text, out result);

            if (!res)
            {
                showMessageBox("Hours To Complete Must Be Numeric.", "NON-NUMERIC HOURS TO COMPLETE!");
                textBoxHoursToComplete.Text = "";
                textBoxHoursToComplete.Focus();
                return false;
            }
            if (result < 1)
            {
                showMessageBox("Hours To Complete Must Be >= 1.", "< 1 HOURS TO COMPLETE ENTERED!");
                textBoxHoursToComplete.Text = "";
                textBoxHoursToComplete.Focus();
                return false;
            }
            HTC = result;
            return true;
        }
        //Validate hourlyRate
        private bool validateHourlyRate(out double result)
        {
            if (textBoxHourlyRate.Text.Trim() == "")
            {
                showMessageBox("Hourly Rate Cannot Be Blank.", "HOURLY RATE IS BLANK!");
                textBoxHourlyRate.Focus();
                result = -1;
                return false;
            }

            bool res = Double.TryParse(textBoxHourlyRate.Text, out result);

            if (!res)
            {
                showMessageBox("Hourly Rate Must Be Numeric.", "NON-NUMERIC HOURLY RATE!");
                textBoxHourlyRate.Text = "";
                textBoxHourlyRate.Focus();
                return false;
            }
            if (result < 0)
            {
                showMessageBox("Hourly Rate Must Be >= 0.", "NEGATIVE HOURLY RATE ENTERED!");
                textBoxHourlyRate.Text = "";
                textBoxHourlyRate.Focus();
                return false;
            }
            HR = result;
            return true;
        }
        private void calculateTotalFee()
        {
            jobs[curNumOfJobs] = textBoxDescription.Text;
            hoursToComplete[curNumOfJobs] = HTC;
            hourlyRate[curNumOfJobs] = HR;
            totalFee = (HTC * HR) + TRIP_FEE;
            ++curNumOfJobs;
        }
        private void printCurrentResults()
        {
            labelDescriptionCurrent.Text = job;
            labelHoursToCompleteCurrent.Text = HTC.ToString();
            labelHourlyRateCurrent.Text = HR.ToString("c");
            labelTotalFeeCurrent.Text = totalFee.ToString("c");

        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }
        private void clearAllFields()
        {
            textBoxDescription.Text = "";
            textBoxHoursToComplete.Text = "";
            textBoxHourlyRate.Text = "";
            labelDescriptionCurrent.Text = "";
            labelHoursToCompleteCurrent.Text = "";
            labelHourlyRateCurrent.Text = "";
            labelTotalFeeCurrent.Text = "";
        }
        private void showMessageBox(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormHaroldsHomeServices_Load(object sender, EventArgs e)
        {

        }
    }
}
