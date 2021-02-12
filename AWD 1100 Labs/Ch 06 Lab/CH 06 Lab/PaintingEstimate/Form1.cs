using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintingEstimate
{
    public partial class FormPaintingEstimate : Form
    {
        public FormPaintingEstimate()
        {
            InitializeComponent();
            
        }
        const decimal PRICE_OF_JOB = 6.0m;
        const double MINLENGTH = 0.0;
        const double MAXLENGTH = 1000.0;
        const double MINWIDTH = 0.0;
        const double MAXWIDTH = 1000.0;
        double length = 0;
        double width = 0;
        double totalArea = 0;
        decimal totalCost = 0.0m;

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            calculateTotalArea();
            calculatePaintEstimate();
           
        }
        private void calculateTotalArea()
        {
            bool keepGoing = true;

            keepGoing = validateIsNumeric(textBoxLength.Text);

            if (keepGoing)
            {
                length = Convert.ToDouble(textBoxLength.Text);

                if ((length < MINLENGTH) || (length > MAXLENGTH))
                {
                    MessageBox.Show("Inputted Length Is Out Of Range ( < 0 or >1000).\n" +
                                     "Please reenter a length within range.",
                                     "OUT OF RANGE LENGTH INPUTTED!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxLength.Text = "";
                    textBoxLength.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Non-Numeric Length Inputted. \n" +
                                    "Please reenter a numeric length.",
                                    "NON-NUMERIC LENGTH INPUTTED!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxLength.Text = "";
                    textBoxLength.Focus();
                    return;
                }
                
            }
            if (keepGoing)
            {
                width = Convert.ToDouble(textBoxWidth.Text);

                if ((width < MINWIDTH) || (width > MAXWIDTH))
                {
                    MessageBox.Show("Inputted Width Is Out Of Range (< 0 or > 1000).\n" +
                                    "Please reenter a width within range.",
                                    "OUT OF RANGE WIDTH INPUTTED!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxWidth.Text = "";
                    textBoxWidth.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Inputted Width Is Non-Numeric. \n" +
                                    "Please reenter a numeric width.",
                                    "NON-NUMERIC WIDTH INPUTTED!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxWidth.Text = "";
                    textBoxWidth.Focus();
                    return;
                }
                
            }
            totalArea = (double)length * (double)width;
            labelTotalArea.Text = "Total Area (sq ft)\n" + totalArea.ToString("f2");
        }
        private void calculatePaintEstimate()
        {
            totalCost = (decimal)totalArea * (decimal)PRICE_OF_JOB;
            labelTotalCost.Text = "Total Cost ($)\n" + totalCost.ToString("c");
        }
        private bool validateIsNumeric(string input)
        {
            double test = 0;
            return double.TryParse(input, out test);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLength.Text = "";
            textBoxWidth.Text = "";
            labelTotalArea.Text = "";
            labelTotalCost.Text = "";
        }
    }
}
