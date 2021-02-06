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
 * Write a GUI program that adds up the number of 
 * eggs produced by some chickens:
    ●	Prompts the user for a number of eggs laid by four chickens.
    ●	Sum the eggs laid and display the total in dozens and eggs.  
        For example, a total of 127 eggs would be 
        displayed as “10 dozen and 7 eggs”.
  *
  *
  */


namespace EggsProducedByChickens
{
    

    public partial class EggsLaid : Form
    {
        public EggsLaid()
        {
            InitializeComponent();
        }

        private void EggsLaid_Load(object sender, EventArgs e)
        {}

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int total = 0;
            total = Convert.ToInt32(textBoxchicken1.Text) + Convert.ToInt32(textBoxChicken2.Text) +
                    Convert.ToInt32(textBoxChicken3.Text) + Convert.ToInt32(textBoxChicken4.Text);
            int dozen = 0;
            dozen = total / 12;
            int eggs = 0;
            eggs = total % 12;

            labeTotalEggsLaid.Text = "A total of " + total + " eggs is " + dozen +
                " dozen and " + eggs + " eggs.";
        }

        private void textBoxTotalEggsLaid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxchicken1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
