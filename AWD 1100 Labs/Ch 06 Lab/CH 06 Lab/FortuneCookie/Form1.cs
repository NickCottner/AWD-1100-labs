using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneCookie
{
    public partial class FormFortuneCookie : Form
    {
        public FormFortuneCookie()
        {
            InitializeComponent();
           
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {

            GenerateFortune(labelFortunes.Text);

        }
        private void GenerateFortune()
        {
            Random random = new Random();
            string[] fortunes =
            {
                "Birthdays are like friends. The more you have the better." ,
                "Your smile is a treasure to all who know you." ,
                "You never hesitate to tackle the most difficult problems." ,
                "The most obvious solution is not always the best." ,
                "If you want the rainbow, you will have to tolerate the rain." ,
                "The early bird gets the worm, but the second mouse gets the cheese." ,
                "From listening comes wisdom and from speaking repentance." ,
                "A smile is your personal welcome mat."
            };

            
        }
        

    }
}
