using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDatabases
{
    public partial class FormGameBreak : Form
    {
        public FormGameBreak()
        {
            InitializeComponent();
        }

        const int LEN = 5;
        const string GAMENOTFOUND = "GAME NOT FOUND";


        string[] name = {"Player's Unknown Battlegrounds (PUBG)", "League of Legends",
                         "Call of Duty Black Ops III", "Battlefield 4", "Super Mario Odyssey"};

        string[] publisher = { "Bluehole", "Riot Games", "Activision", 
                                "Electronic Arts (EA)", "Nintendo" };

        decimal[] price = { 35.00m, 0.00m, 60.00m, 20.00m, 60.00m, };

        int index = -1;

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = doesSearchItemExist();
            
            if (keepGoing)
            {
                printResults();
            }
            else
            {
                labelName.Text = "Name: " + GAMENOTFOUND;
                labelPublisher.Text = "Publisher: " + GAMENOTFOUND;
                labelPrice.Text = "Price: " + GAMENOTFOUND;
            }
            
        }
        private bool doesSearchItemExist()
        {
            index = -1;

            bool retVal = false;
            string item = "";

            if(textBoxGameInfo.Text.Trim() == "")
            {
                MessageBox.Show("No Search Item Entered.", "NO SEARCH ITEM ENTERED!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxGameInfo.Focus();
            }
            else
            {
                item = textBoxGameInfo.Text.ToLower();
                for (int lcv = 0; lcv < name.Length; ++lcv)
                {
                    if (name[lcv].ToLower().Contains(item))
                    {
                        retVal = true;
                        index = lcv;
                        break;
                        
                    }
                    else if (publisher[lcv].ToLower().Contains(item))
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
        private void printResults()
        {
            labelName.Text = "Name: " + name[index];
            labelPublisher.Text = "Publisher: " + publisher[index];
            labelPrice.Text = "Price: " + price[index].ToString("c");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }
        private void clearAndSetFocus()
        {
            textBoxGameInfo.Text = "";
            labelName.Text = "";
            labelPublisher.Text = "";
            labelPrice.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            exitApplication();
        }
        private void exitApplication()
        {
            if (MessageBox.Show("Do You Really Want To Exit?" , "EXIT PROGRAM?" , 
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                                   == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
