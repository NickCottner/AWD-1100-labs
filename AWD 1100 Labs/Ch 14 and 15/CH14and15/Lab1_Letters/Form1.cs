using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Letters
{
    public partial class FormLetterDelivery : Form
    {
        public FormLetterDelivery()
        {
            InitializeComponent();
        }
        // Global Constants
        const int TOTALELEMENTS = 10;

        // Global Variables
        List<Letter> letter = new List<Letter>(TOTALELEMENTS);
        List<CertifiedLetter> certifiedLetter = new List<CertifiedLetter>(TOTALELEMENTS);
        string[] sentLetters = new string[TOTALELEMENTS];
        int numElements = 0;

        private void buttonSend_Click(object sender, EventArgs e)
        {
            bool keepGoing = validateRecipient();

            if (keepGoing)
            {
                keepGoing = validateSentDate();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = isThereATrackingNumber();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                instantiateCertifiedLetter();
            }
            else
            {
                instantiateANonCertifiedLetter();
            }
        }
        private bool validateRecipient()
        {
            if (textBoxRecipient.Text.Trim().Equals(string.Empty))
            {
                showMessage("Recipient Name Cannot Be Empty!\n" + "Please Enter A Name." , "EMPTY RECIPIENT");
                textBoxRecipient.Focus();
                return false;
            }
            return true;
        }
        private bool validateSentDate()
        {
            try
            {
                DateTime.Parse(textBoxSentDate.Text.Trim());
                return true;
            }
            catch (Exception e)
            {
                showMessage("Invalid Date Format!\n" + "Please Enter A Valid Date.\r\n" + e.Message, "INVALID DATE INPUTTTED");
                textBoxSentDate.Text = string.Empty;
                textBoxSentDate.Focus();
                return false;
            }
        }
        private bool isThereATrackingNumber()
        {
            if (textBoxTrackingNumber.Text.ToString() == " ")
            {
                return false;
            }
            return true;
        }
        private void instantiateCertifiedLetter()
        {
            if (numElements < TOTALELEMENTS)
            {
                CertifiedLetter cL = new CertifiedLetter(textBoxRecipient.Text, 
                                                         Convert.ToDateTime(textBoxSentDate.Text),
                                                         textBoxTrackingNumber.Text);
                certifiedLetter.Add(cL);
                textBoxLetterHistory.Text += cL.ToString() + "\r\n";
                sentLetters = textBoxLetterHistory.Text.Split('\n');
                labelAdditionalFee.Visible = true;
                numElements++;
            }
            else
            {
                showMessage("Cannot Add Anymore Elements. List is Already Full.",
                            "LIST FULL!");
                labelAdditionalFee.Visible = false;
            }

            displayArrayContents();
        }

        private void instantiateANonCertifiedLetter()
        {
            if (numElements < TOTALELEMENTS)
            {
                Letter L = new Letter(textBoxRecipient.Text, Convert.ToDateTime(textBoxSentDate.Text));
                letter.Add(L);
                labelAdditionalFee.Visible = false;
                textBoxLetterHistory.Text += L.ToString() + "\r\n";
                sentLetters = textBoxLetterHistory.Text.Split('\n');
                labelAdditionalFee.Visible = true;
                numElements++;

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            textBoxRecipient.Text = string.Empty;
            textBoxSentDate.Text = string.Empty;
            textBoxTrackingNumber.Text = string.Empty;
            labelAdditionalFee.Text = string.Empty;
            textBoxRecipient.Focus();
        }
        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void FormLetterDelivery_Load(object sender, EventArgs e)
        {
            Letter L0 = new Letter("Mom", Convert.ToDateTime("3/23/2021"));
            textBoxLetterHistory.Text += L0 + "\r\n";
            sentLetters[0] = textBoxLetterHistory.Text;
            numElements++;
            Letter L1 = new Letter("Dad", Convert.ToDateTime("3/23/2021"));
            textBoxLetterHistory.Text += L1 + "\r\n";
            sentLetters[1] = textBoxLetterHistory.Text;
            numElements++;

            CertifiedLetter cL2 = new CertifiedLetter("Best Buy", Convert.ToDateTime("3/23/2021"), "1234");
            textBoxLetterHistory.Text += cL2 + "\r\n";
            sentLetters[2] = textBoxLetterHistory.Text;
            numElements++;
            CertifiedLetter cL3 = new CertifiedLetter("First Commmunity", Convert.ToDateTime("3/23/2021"), "1234");
            textBoxLetterHistory.Text += cL3 + "\r\n";
            sentLetters[3] = textBoxLetterHistory.Text;
            numElements++;
            
            displayArrayContents();
        }
        private void displayArrayContents()
        {
            string str = " ";

            for (int lcv = 0; lcv < sentLetters.Length - 1; ++lcv)
            {
                str += "sentLetters(" + lcv.ToString() + " ):" + sentLetters[lcv] + "\n";
            }
            MessageBox.Show("Contents of Array sentLetters:\n" + str, "ARRAY CONTENTS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
