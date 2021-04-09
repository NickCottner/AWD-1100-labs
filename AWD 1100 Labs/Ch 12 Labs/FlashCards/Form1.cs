using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormFC : Form
    {
        public FormFC()
        {
            InitializeComponent();
        }
        // Global Constant
        const int MAXLEN = 10;      //Max Number of Flashcard objects

        //Global Variables
        int lcv = 0;                //Loop control variable

        //Creating a list of flashcard objects
        List<FlashCard> flashCards = new List<FlashCard>()
        {new FlashCard("internet", "The Internet is the wiring that allows computers all over the world " +
            "to communicate."),
         new FlashCard("world wide web", "The World Wide Web is a system that operates via the wiring that is " +
             "the Internet."),
         new FlashCard("web browser", "A program you use to look at, and navigate between, pages on " +
             "the World Wide Web."),
         new FlashCard( "cookie", "A small text file sent to your computer by a web site you have " +
             "visited. "),
         new FlashCard("captcha", "Strings of letters and numbers typed in before something can be " +
             "accessed.")
        };

         private void buttonDefine_Click(object sender, EventArgs e)
        {
            //Check for no input
            if (textBoxTerm.Text.Trim() == "")
            {
                showMessageBox("No term entered into the textBox!", "TERM TEXTBOX EMPTY");
                textBoxTerm.Focus();
                return;
            }

            //There is something in the term textbox. See if there is a definition
            //for this term or not.
            for (lcv = 0; lcv < flashCards.Count; ++lcv)
            {
                //if term found in list, get the definition
                if (textBoxTerm.Text.ToLower() == flashCards[lcv].GetTerm())
                {
                    // Get Associated Definition
                    labelDefinition.Text = flashCards[lcv].GetDefinition();
                    clearBottom();

                    //Make definition label visible
                    labelDefinition.Visible = true;
                    return;
                }
                    
            }

            // Term was not found in the list, "possibly create a new term
            if(flashCards.Count < MAXLEN)
            {
                //Add new term to list
                labelDontKnowYet.Visible = true;
                textBoxDefiniton.Visible = true;
                textBoxDefiniton.Text = "";

                buttonAdd.Visible = true;
                labelDefinition.Visible = false;
                textBoxDefiniton.Focus();
            }
            // The list is already full, (i.e. the count is MAXLEN)
            else
            {
                showMessageBox("Failed Attempt To Add New Term. List Already Filled",
                               "FLASH CARD LIST IS ALREADY FULL");
                textBoxDefiniton.Text = "";
                textBoxDefiniton.Visible = false;
                buttonAdd.Visible = false;
                labelDontKnowYet.Visible = false;
                textBoxTerm.Focus();
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Instantiate a new flashcard object.
            flashCards.Add(new FlashCard(textBoxTerm.Text, textBoxDefiniton.Text));
            labelDefinition.Text = textBoxDefiniton.Text;
            showMessageBox("The Term " + textBoxTerm.Text + " was successfully added to the list",
                           "TERM ADDED TO THE LIST!");
            clearBottom();
            clearTop();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearBottom();
            clearTop();
        }
        private void clearTop()
        {
            textBoxTerm.Text = "";
            labelDefinition.Text = "";
            labelDefinition.Visible = false;
            textBoxTerm.Focus();
        }

        private void clearBottom()
        {
            labelDontKnowYet.Visible = false;
            textBoxDefiniton.Text = "";
            textBoxDefiniton.Visible = false;
            buttonAdd.Visible = false;
        }

        private void FormFC_Load(object sender, EventArgs e)
        {
            clearBottom();
            labelDefinition.Visible = false;
        }
        //Programmer written method to handle all MessageBox entries
        private void showMessageBox(string title, string text)
        {
            MessageBox.Show(title, 
                            text, 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
        }

    }    
}
