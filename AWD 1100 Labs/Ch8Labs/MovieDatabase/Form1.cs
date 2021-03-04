using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase
{
    public partial class FormMovieDatabase : Form
    {
        public FormMovieDatabase()
        {
            InitializeComponent();
        }

        const int LEN = 5;
        const string MNF = "MOVIE NOT FOUND";

        string[] name = {"Black Widow", "Deadpool", "Avengers Endgame", "Logan" , 
            "Captain Marvel"};

        string[] director = {"Cate Shortland", "Tim Miller", "Anthony Russo & Joe Russo", 
        "James Mangold","Anna Boden & Ryan Fleck" };

        string[] description = {"A film about Natasha Romanoff in her quests between the films Civil War and Infinity War.",
                                "A wisecracking mercenary gets experimented on and becomes immortal but ugly." , 
                                "The Avengers assemble to undo what Thanos did in Infinity War.",
                                "An elderly wolverine, sets out to help out a mutant little girl.",
                                "Carol Danvers becomes one of the universe's most powerful heroes " +
                "                when Earth is caught in the middle of a galactic war between two alien races."};
        int index = -1;


        private void labeltheName_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = doesMovieExist();
            if (keepGoing)
            {
                showResults();
            }
            else
            {
                labeltheName.Text = MNF;
                labeltheDirector.Text = MNF;
                labeltheDescription.Text = MNF;
            }
        }
        private bool doesMovieExist()
        {
            index = -1;

            bool retVal = false;
            string item = "";

            if (textBoxSearchItem.Text.Trim() == "")
            {
                MessageBox.Show("No Search Item Entered.", "NO SEARCH ITEM ENTERED!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearchItem.Focus();
            }
            else
            {
                item = textBoxSearchItem.Text.ToLower();
                for (int lcv = 0; lcv < name.Length; ++lcv)
                {
                    if (name[lcv].ToLower().Contains(item))
                    {
                        retVal = true;
                        index = lcv;
                        break;

                    }
                    else if (director[lcv].ToLower().Contains(item))
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
        private void showResults()
        {
            labeltheName.Text = name[index];
            labeltheDirector.Text = director[index];
            labeltheDescription.Text = description[index];
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }
        private void clearAndSetFocus()
        {
            textBoxSearchItem.Text = "";
            labeltheName.Text = "";
            labeltheDirector.Text = "";
            labeltheDescription.Text = "";
            textBoxSearchItem.Focus();
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
        }
    }
}
