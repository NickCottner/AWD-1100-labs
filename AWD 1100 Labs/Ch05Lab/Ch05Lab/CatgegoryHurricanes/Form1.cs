using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 *   Write a GUI program that estimates the category of a hurricane based on the wind speed (based on the Saffir-Simpson Hurricane Scale):
    ●	Category 5 hurricanes have sustained winds of at least 157 miles per hour.
    ●	Category 4 hurricanes have sustained winds of at least 130 miles per hour.
    ●	Category 3 hurricanes have sustained winds of at least 111 miles per hour.
    ●	Category 2 hurricanes have sustained winds of at least 96 miles per hour.
    ●	Category 1 hurricanes have sustained winds of at least 74 miles per hour.
    ●	Any storm with winds of less than 74 miles per hour is 
        not classified as a hurricane.
*
*
*/


namespace CatgegoryHurricanes
{
    public partial class CategoryofHurricane : Form
    {
        public CategoryofHurricane()
        {
            InitializeComponent();
        }

        private void textBoxWindSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            string Category5 = "CATEGORY 5";
            string Category4 = "CATEGORY 4";
            string Category3 = "CATEGORY 3";
            string Category2 = "CATEGORY 2";
            string Category1 = "CATEGORY 1";
            string Category0 = "NOT A HURRICANE";
            double WindSpeed = Convert.ToDouble(textBoxWindSpeed.Text);

            if (WindSpeed >= 157.0 )
            {
                textBoxCategory.Text = Category5;
            }
            else if ((WindSpeed >= 130.0) && (WindSpeed < 157.0))
                    {
                        textBoxCategory.Text = Category4;
                    }
            else if ((WindSpeed >= 111.0) && (WindSpeed < 130))
            {
                textBoxCategory.Text = Category3;
            }
            else if ((WindSpeed >= 96.0) && (WindSpeed < 111.0))
            {
                textBoxCategory.Text = Category2;
            }
            else if ((WindSpeed >= 74.0) && (WindSpeed < 96.0))
            {
                textBoxCategory.Text = Category1;
            }
            else
            {
                textBoxCategory.Text = Category0;
            }
            
        }
    }
}
