using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScoreGui
{
   

    public partial class FormTestScores : Form

    {
        public FormTestScores()
        {
            InitializeComponent();     
        }

        const decimal MINSCORE = 0.0m;
        const decimal MAXSCORE = 100.0m;



        private void buttonEnter_Click(object sender, EventArgs e)
        {
            decimal sumScores = 0.0m;
            decimal avgScores = 0.0m;
            decimal testScore = 0.0m;
            bool keepGoing = true;
            int numOfScores = 0;

            keepGoing = validateIsNumeric(textBoxTestScore.Text);
            if (keepGoing)
            {
                testScore = Convert.ToDecimal(textBoxTestScore.Text);

                if ((testScore < MINSCORE) || (testScore > MAXSCORE))
                {
                    printMessageBox("Out-of-Range Value Inputted." + " Please reenter a valid test score. ",
                        "OUT-RANGE-VALUE INPUTTED! ");

                    return;
                }
                else
                {
                    keepGoing = validateIsNumeric(textBoxTestScore.Text);
                }
            }
            else
            {
                printMessageBox("Non-numeric value inputted." + " Please reenter a numeric value. ",
                    "NON-NUMERIC VALUE INPUTTED.");

                return;
            }

            for (numOfScores = 0; numOfScores < 3; numOfScores++)
            {
                sumScores += testScore;
                numOfScores ++;
                avgScores = sumScores / numOfScores;
            }
            
            
            labelNumberofScores.Text = "Number of Scores: " + numOfScores.ToString();
            labelSum.Text = "Sum of test scores: " + sumScores.ToString();
            labelAverage.Text = "Average test score: " + avgScores.ToString();
                

            





        }
        private bool validateIsNumeric (string input)
        {
            decimal test = 0;

            return decimal.TryParse(input, out test);
        }
      
        private void printMessageBox(String text, String title)
        {
            MessageBox.Show(text, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
