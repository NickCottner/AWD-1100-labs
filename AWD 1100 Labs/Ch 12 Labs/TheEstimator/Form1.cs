using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheEstimator
{
    public partial class FormTileEstimator : Form
    {
        public FormTileEstimator()
        {
            InitializeComponent();
        }
        //Global Constant
        const int MAXLEN = 5;

        //Global Variables
        string[] names = new string[MAXLEN];
        string name = " ";
        int[] widths = new int[MAXLEN];
        int[] lengths = new int[MAXLEN];
        int[] sqft = new int[MAXLEN];
        int[] boxNeeded = new int[MAXLEN];
        int curNumRooms = 0;
        int width = 0;
        int length = 0;
        int b = 0;
        int totBoxesNeeded = 0;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            int result;

            //Validate non-empty name
            if(keepGoing)
            {
                keepGoing = validateName();
            }

            //If ture, name was not empty
            if(keepGoing)
            {
                //Validate width is: 
                //1) Not Empty
                //2) > 1
                keepGoing = validateWidth(out result);
            }
            else
            {
                //Name was empty
                return;
            }
            if (keepGoing)
            {
                //Validate length is:
                //1) Not empty
                //2) > 1
                keepGoing = validateLength(out result);
            }
            else
            {
                //width was empty
                return;
            }

            if (keepGoing)
            {
                //Check for already filled list
                if (curNumRooms >= MAXLEN)
                {
                    //Show corresponding messagebox
                    showMessageBox("Attempted To Enter Into Already Filled List.",
                                    "LIST FILLED - CANNOT ENTER ANYMORE!");
                    return;
                }
                else
                {
                    //List not full. Add the current room to the associated
                    //name, width, and length arrays.
                    calculateCurrentRoom();
                    fillUpOutput();
                }

            }    
                
        }
        //Validate name not empty
        private bool validateName()
        {
            if (textBoxName.Text.Trim() == "")
            {
                //Name empty and return false
                showMessageBox("Name Field Canot Be Blank", "BLANK NAME FIELD!");
                return false;
            }
            //Name not empty. Return True
            name = textBoxName.Text;
            return true;
        }

        //Validate the width is:
        // 1) Not empty
        // 2) > 0
        private bool validateWidth(out int result)
        {
            if (textBoxWidth.Text.Trim() == "")
            {
                //Width is empty, message box and return false
                showMessageBox("Width Field Cannot Be Empty.", "EMPTY WIDTH FIELD!");
                result = -1;
                return false;
            }

            //width textBox was not empty. Try to parse
            bool res = Int32.TryParse(textBoxWidth.Text, out result);

            //Non-Numeric Width.
            //MessageBox and return false.
            if (!res)
            {
                showMessageBox("Width Field Must Be Numeric", "NON-NUMERIC WIDTH FIELD!");
                return false;
            }

            //If negative width
            //MessageBox and return false
            if (result < 0)
            {
                showMessageBox("Width Field Must Be Positive.", "NEGATIVE WIDTH FIELD ENTERED!");
                return false;
            }

            //Valid value for width. return True.
            width = result;
            showMessageBox("Current Value of Width Is: " + width.ToString(), "Validated In Function validateWidth().");
            return true;
        }

        //Validate the length is:
        // 1) Not empty
        // 2) > 0
        private bool validateLength(out int result)
        {
            if (textBoxLength.Text.Trim() == "")
            {
                //Length is empty, message box and return false
                showMessageBox("Length Field Cannot Be Empty.", "EMPTY LENGTH FIELD!");
                result = -1;
                return false;
            }

            //length textBox was not empty. Try to parse
            bool res = Int32.TryParse(textBoxLength.Text, out result);

            //Non-Numeric length.
            //MessageBox and return false.
            if (!res)
            {
                showMessageBox("Length Field Must Be Numeric", "NON-NUMERIC LENGTH FIELD!");
                return false;
            }

            //If negative length
            //MessageBox and return false
            if (result < 0)
            {
                showMessageBox("Length Field Must Be Positive.", "NEGATIVE LENGTH FIELD ENTERED!");
                return false;
            }

            //Valid value for length. return True.
            length = result;
            showMessageBox("Current Value of Length Is: " + length.ToString(), "Validated In Function validateLength().");
            return true;
        }

        //Calculate both:
        // 1) square footage of current room.
        // 2) num boxes needed for current room.
        private void calculateCurrentRoom()
        {
            names[curNumRooms] = textBoxName.Text;
            widths[curNumRooms] = width;
            lengths[curNumRooms] = length;
            sqft[curNumRooms] = length * width;

            b = sqft[curNumRooms] / 12;
            if (sqft[curNumRooms] % 12 > 0)
            {
                ++b;
            }

            totBoxesNeeded += b;
            boxNeeded[curNumRooms] = b;
            ++curNumRooms;
        }

        //Display the associated textbox values
        private void fillUpOutput()
        {
            string tot = "";

            textBoxRooms.Text = "";
            textBoxRooms.Text = curNumRooms.ToString() + " / 5";
            textBoxTotalBoxesNeeded.Text = totBoxesNeeded.ToString();

            tot = name + " (";
            tot += width + "x";
            tot += length + ") ";
            tot += "needs ";
            tot += b.ToString();
            tot += " boxes";
            textBoxTotals.Text += tot + "\r\n";
        }
        
        //Executes when clear button is clicked
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }
        
        //clears out associated textboxes and global variables
        private void clearAllFields()
        {
            textBoxName.Text = "";
            textBoxWidth.Text = "";
            textBoxLength.Text = "";
            b = 0;
            length = 0;
            width = 0;
            textBoxName.Focus();
        }
        private void showMessageBox(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       //Executes when the form is loaded
        private void FormTileEstimator_Load(object sender, EventArgs e)
        {
            clearAllFields();
        }
    }
}
