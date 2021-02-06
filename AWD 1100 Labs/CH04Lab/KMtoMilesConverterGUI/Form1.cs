using System;
using System.Windows.Forms;

/* Write a GUI program that converts distances 
 * between miles and kilometers:
        ●	Declares a named constant named KM_PER_MILE which holds the 
            number of kilometers in a mile (1.6 km per mile).
        ●	Prompts the user for a distance in miles or kilometers.
        ●	The user can convert miles to kilometers.
        ●	The user can convert kilometers to miles.
        ●	The program displays the distance in both kilometers 
            and miles. For example: “3.0 miles is 4.8 kilometers”
*/
  

namespace KMtoMilesConverterGUI
{
    public partial class Ch04Lab : Form
    {
        const double km_per_mile = 1.6;
        double miles = 0.0;
        double kilometers = 0.0;

        public Ch04Lab()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConvertToKm_Click(object sender, EventArgs e)
        {
            double miles, converttokm;
            miles = double.Parse(textBoxMiles.Text);
            converttokm = miles * 1.6;
            textBoxKm.Text = Convert.ToString(converttokm);
            labelmilesiskm.Text = miles + "miles is " + textBoxKm.Text + " kilometers. ";

        }

        private void btnConvertToMiles_Click(object sender, EventArgs e)
        {
            double kilometers, converttomiles;
            kilometers = double.Parse(textBoxKm.Text);
            converttomiles = kilometers * .6214;
            textBoxMiles.Text = Convert.ToString(converttomiles);
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void textBoxConversion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelmilesiskm_Click(object sender, EventArgs e)
        {
            labelmilesiskm.Text = miles.ToString() + " miles is " +
                 kilometers.ToString() + " kilometers";
            
        }

        private void Ch04Lab_Load(object sender, EventArgs e)
        {

        }
    }
}
