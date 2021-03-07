using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSearch
{
    public partial class FormSL : Form
    {
        public FormSL()
        {
            InitializeComponent();
        }
        const int LEN = 10;
        const string SNF = "STUDENT NOT FOUND";

        string[] firstName = {"Nick", "Damian", "Wade", "Natasha", "Pepper", "Luke", "Kelly", "Elijah",
                               "Tony", "Steve"};
        string[] lastName = {"Cottner", "Salvatore", "Wilson", "Romanov", "Potts", "Muich", "Berry" , "Mikaelson",
                              "Stark", "Rogers"};
        string[] course = {"AWD 1100 L 31", "AWD 1000 L02", "AWD 1200 L41", "AWD 1300 L52", "BUS 1000 O43",
                            "BUS 1100 O33", "BUS 1200 O53", "BUS 1300 O23", "AWD 1100 L 21", "BUS 1000 O13" };
        string[] courseGrade = { "A", "C", "B", "C", "B", "A", "F", "D", "B", "C" };
        string[] gpa = { "4.0", "2.0", "3.0", "2.0", "3.0", "4.0", "0.0", "1.0", "3.0", "2.0" };

        int index = -1;

        private void buttonFNSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = doesSearchbyFNExist();

            if (keepGoing)
            {
                showStudentResults();
            }
            else
            {
                labelName.Text = SNF;
                labelTC.Text = "";
                labelTCG.Text = "";
                labelTGPA.Text = "";
            }
        }
        private bool doesSearchbyFNExist()
        {
            index = -1;
            bool retVal = false;
            string item = "";

            if (textBoxFN.Text.Trim() == "")
            {
                MessageBox.Show("No Search Item Entered.", "NO SEARCH ITEM ENTERED!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFN.Focus();
            }
            else
            {
                item = textBoxFN.Text.ToLower();
                for (int lcv = 0; lcv < firstName.Length; ++lcv)
                {
                    if (firstName[lcv].ToLower().Contains(item))
                    {
                        retVal = true;
                        index = lcv;
                        break;

                    }
                    else if (lastName[lcv].ToLower().Contains(item))
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

        private void buttonLNSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = doesSearchbyLNExist();

            if (keepGoing)
            {
                showStudentResults();
            }
            else
            {
                labelName.Text = SNF;
                labelTC.Text = "";
                labelTCG.Text = "";
                labelTGPA.Text = "";
            }
        }
        private bool doesSearchbyLNExist()
        {
            index = -1;
            bool retVal = false;
            string item = "";

            if (textBoxLN.Text.Trim() == "")
            {
                MessageBox.Show("No Search Item Entered.", "NO SEARCH ITEM ENTERED!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLN.Focus();
            }
            else
            {
                item = textBoxLN.Text.ToLower();
                for (int lcv = 0; lcv < lastName.Length; ++lcv)
                {
                    if (lastName[lcv].ToLower().Contains(item))
                    {
                        retVal = true;
                        index = lcv;
                        break;

                    }
                    else if (firstName[lcv].ToLower().Contains(item))
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
        private void showStudentResults()
        {
            labelName.Text = firstName[index] +  lastName[index];
            labelTC.Text = course[index];
            labelTCG.Text = courseGrade[index];
            labelTGPA.Text = gpa[index];
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAndSetFocus();
        }
        private void ClearAndSetFocus()
        {
            textBoxFN.Text = "";
            textBoxLN.Text = "";
            labelName.Text = "";
            labelTC.Text = "";
            labelTCG.Text = "";
            labelTGPA.Text = "";
            textBoxFN.Focus();
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

