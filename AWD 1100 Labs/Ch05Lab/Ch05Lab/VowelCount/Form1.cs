using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VowelCount
{
    public partial class FormVowels : System.Windows.Forms.Form
    {
        public FormVowels()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            int numberOfVowels = CountVowels();

            labelNumberVowels.Text = "There are " + numberOfVowels.ToString() + " vowels in your phrase.";

        }
        
        

        private void textBoxEnterPhrase_TextChanged(object sender, EventArgs e)
        {

        }
        private int CountVowels()
        {
            
                int number = 0;
                int len = textBoxEnterPhrase.Text.ToString().ToUpper().Length;
                string input = textBoxEnterPhrase.Text.ToString().ToUpper();

                for (int lcv = 0; lcv < len; ++lcv)
                {
                    switch (input[lcv])
                    {
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            ++number;
                            break;

                        default:
                            break;
                    }
                }

                return number;
            
        }
    }
}
