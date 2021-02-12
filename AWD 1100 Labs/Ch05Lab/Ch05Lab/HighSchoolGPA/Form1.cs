using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighSchoolGPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string accept = "ACCEPT";
        string reject = "REJECT";
        double gpa = 0.0;
        double admitScore = 0.0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelacceptorreject_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnadmit_Click(object sender, EventArgs e)
        {
            
            IsStudentAccepted();
        }

        private void textBoxgpa_TextChanged(object sender, EventArgs e)
        {

        }
        private void IsStudentAccepted()
        {
            gpa = Convert.ToDouble(textBoxgpa.Text);
            admitScore = Convert.ToDouble(textBoxadmissiontestscore.Text);
            bool keepGoing = true;
            if (keepGoing)
            {
                if ((gpa >= 3.0) && (admitScore >=60))
                {
                    labelacceptorreject.Text = accept;
                }
                else if ((gpa < 3.0) && (admitScore >= 80))
                {
                    labelacceptorreject.Text = accept;
                }
                else
                {
                    labelacceptorreject.Text = reject;
                }
            }
            
        }
    }
}
