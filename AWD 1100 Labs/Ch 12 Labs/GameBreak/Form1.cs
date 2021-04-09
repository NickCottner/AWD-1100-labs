using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBreak
{
    public partial class FormGameBreak : Form
    {
        public FormGameBreak()
        {
            InitializeComponent();
        }
        //Global Constants
        const int MAXLEN = 5;
        const string GNF = "GAME NOT FOUND";

        //Global Variables
        List<Game> games = new List<Game>()
        {new Game("Player Unknown's Battlegrounds (PUBG)",   "Bluehole",             35M),
         new Game("League of Legends",                       "Riot Games",           0M),
         new Game("Call of Duty: Black Ops III",             "Activision",           60M),
         new Game("Battlefield 4",                           "Electronic Arts (EA)", 20M),
         new Game("Super Mario Odyssey",                     "Nintendo",             60M)
        };

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int position = searchForGame();
            
            // if position returned was between 1 and 4 show associated game information
            if ((position >= 0) && (position <= (MAXLEN - 1)))
            {
                showGameInfo(position);
            }
            // position was not found (-1 was returned) show GNF
            // in all 3 associated labels
            else
            {
                showGameNotFoundInfo();
            }
        }
        //if game exists (i.e. there is a match on what was inputted into the textbox
        //with either one of the game names or one of the game publishers.
        //return index. otherwise return -1.
        public int searchForGame()
        {
            string searchTerm = textBoxGame.Text;

            //Traverse through game list. if a match is found
            // return the position. else return -1.
            for (int lcv = 0; lcv < MAXLEN; ++lcv)
            {
                if ((games[lcv].GetName().ToLower() == searchTerm.ToLower() || 
                    games[lcv].GetPublisher().ToLower() == searchTerm.ToLower()))
                {
                    return lcv;
                }
            }
            return -1;
        }
        public void showGameInfo(int p)
        {
            //Here p represents the selected game
            labelName.Text = games[p].GetName();
            labelPublisher.Text = games[p].GetPublisher();
            labelPrice.Text = games[p].GetPrice().ToString("c");
        }
        public void showGameNotFoundInfo()
        {
            labelName.Text = GNF;
            labelPublisher.Text = GNF;
            labelPrice.Text = GNF;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAllOutputFields();
        }
        public void clearAllOutputFields()
        {
            labelName.Text = "";
            labelPublisher.Text = "";
            labelPrice.Text = "";
            textBoxGame.Text = "";
            textBoxGame.Focus();
        }

        private void FormGameBreak_Load(object sender, EventArgs e)
        {
            clearAllOutputFields();
        }
    }
}
