using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardMasker
{
    public partial class FormCCMasker : Form
    {
        public FormCCMasker()
        {
            InitializeComponent();
        }
        char maskCharacter = '#';
        int lastFourDigits = 4;

        private void buttonMask_Click(object sender, EventArgs e)
        {
            string maskedNumber = "";
            string creditCardNumber = "";
            creditCardNumber = Convert.ToString(textBoxCCNumber.Text);
            maskedNumber = MaskNumber(creditCardNumber);
            labelMaskedCC.Text = maskedNumber;

        }
        private string MaskNumber(string cred)
        {
            string output = "";
            char ch = ' ';
            for (int lcv = 0; lcv < cred.Length - lastFourDigits; ++lcv)
            {
                ch = cred[lcv];
                if (char.IsDigit(ch) || char.IsLetter(ch))
                {
                    output += maskCharacter;
                }
                else if (char.IsWhiteSpace(ch))
                {
                    output += " ";
                }
            }
            output += cred.Substring(cred.Length - 4, lastFourDigits);
            return output;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCCNumber.Text = "";
            labelMaskedCC.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            applicationExit();
        }
        private void applicationExit()
        {
            if (MessageBox.Show("Do You Really Want To Exit?", "EXIT PROGRAM?",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                              == DialogResult.Yes)
            {
                Application.Exit();
            }


        }    }
}
