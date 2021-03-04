using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhraseSorter
{
    public partial class FormPhraseSort : Form
    {
        public FormPhraseSort()
        {
            InitializeComponent();
        }
        
        private void buttonSort_Click(object sender, EventArgs e)
        {
            SortPhrase();
        }
        private void SortPhrase()
        {
            string phrase = "";
            string[] words = phrase.Split(textBoxPhrase.Text);
            labelSortedPhrase.Text = phrase;
            
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPhrase.Text = "";
            labelSortedPhrase.Text = "";
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
}
