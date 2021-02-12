using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardMaster
{
    public partial class FormCardMasker : Form
    {
        public FormCardMasker()
        {
            InitializeComponent();
        }
        char maskCharacter = 'X';
        int lastFourDigits = 4;
        
        private void buttonMask_Click(object sender, EventArgs e)
        {
            string maskedNumber = "";
            string creditCardNumber = "";
            creditCardNumber = Convert.ToString(textBoxCardNumber.Text);
            maskedNumber = MaskNumber(creditCardNumber);
            labelMaskedNumber.Text = maskedNumber;
            
        }
        private string MaskNumber(string cred)
        {
            string output = "";
            char ch = ' ';
            for (int lcv = 0; lcv < cred.Length - lastFourDigits; ++lcv )
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
    }
}
