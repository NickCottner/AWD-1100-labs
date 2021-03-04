using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseGUI
{
    public partial class FormReverse4 : Form
    {
        public FormReverse4()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Reverse4();
        }
        private void Reverse4(ref int n1, ref int n2, ref int n3, ref int n4)
        {

            int temp = n4;
            int temp2 = n1;
            n4 = temp2;
            n1 = temp;

            temp = n3;
            temp2 = n2;
            n3 = temp2;
            n2 = temp;

            return;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNumber1.Text = "";
            textBoxNumber2.Text = "";
            textBoxNumber3.Text = "";
            textBoxNumber4.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            {
                applicationExit();
            }
        }
        private void applicationExit()
        {
            if (MessageBox.Show("Do You Really Want To Exit?", "EXIT PROGRAM?",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                              == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
}
