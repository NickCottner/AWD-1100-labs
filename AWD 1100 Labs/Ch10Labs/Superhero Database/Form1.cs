using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Superhero_Database
{
    public partial class FormSHDB : Form
    {
        public FormSHDB()
        {
            InitializeComponent();
        }
        const int LEN = 6;

        string[] images = {"C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\Labs\\AWD 1100 Labs\\Ch10Labs\\Superhero Database\\Images\\Insert Image.png",
                           "C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\Labs\\AWD 1100 Labs\\Ch10Labs\\Superhero Database\\Images\\black widow.jfif",
                           "C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\Labs\\AWD 1100 Labs\\Ch10Labs\\Superhero Database\\Images\\deadpool.jpg",
                           "C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\Labs\\AWD 1100 Labs\\Ch10Labs\\Superhero Database\\Images\\winter soldier.jfif",
                           "C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\Labs\\AWD 1100 Labs\\Ch10Labs\\Superhero Database\\Images\\Drax.jpg",
                           "C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\Labs\\AWD 1100 Labs\\Ch10Labs\\Superhero Database\\Images\\Gamora.jpg"};
        string[] names = { "Please Select A Hero", "Black Widow", "Deadpool", "Winter Solider", "Drax", "Gamora" };
        string[] likes = { "", "Bruce Banner", "Vanessa Carlysle", "Dolores", "Ovette", "Peter Quill" };
        string[] dislikes = { "", "Red Room", "Ajax", "HYDRA", "Thanos", "Chitauri" };
        string[] superpowers = {"", "Master Spy", "Self Regenerating Mercenary", "Enhanced Super Solider",
                                "Kylosian Physiology", "Bionically Enhanced Zehoberei Physiology"};
        string[] bios = {"",
                          "Natasha Romanov was born in 1984, \nand was recruited " +
                          "by the KGB into the Red Room Academy.",
                          "Wade Wilon is a disfigured merc with a mouth \nwho has been in Marvel comics since 1991.",
                          "James Barnes is the best friend of Steve Rogers, \nand he joined the military at the beginning of World War 2.",
                          "Drax comes from the Kylosian people, \nwho set out to get vengeance for the murder of his wife.",
                          "Gamora is a member of the Guardians of the Galaxy, \nin which she is a former assasin and daughter of Thanos."};
        string[] wikis = {"",
                           "https://marvelcinematicuniverse.fandom.com/wiki/Black_Widow",
                           "https://en.wikipedia.org/wiki/Deadpool",
                           "https://marvelcinematicuniverse.fandom.com/wiki/Winter_Soldier",
                           "https://marvelcinematicuniverse.fandom.com/wiki/Drax_the_Destroyer",
                           "https://marvelcinematicuniverse.fandom.com/wiki/Gamora"};

        private void FormSHDB_Activated(object sender, EventArgs e)
        {
            for (int lcv = 0; lcv < LEN; ++lcv)
            {
                comboBoxSH.Items.Add(names[lcv]);
                comboBoxSH.SelectedIndex = 0;
            }
        }

        private void comboBoxSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxSH.SelectedIndex;

            pictureBoxSH.Image = Image.FromFile(images[index]);
            labelName.Text = names[index];
            labelTheLikes.Text = likes[index];
            labelTheDislikes.Text = dislikes[index];
            labelTheSuperpower.Text = superpowers[index];
            labelTheBiography.Text = bios[index];
            labelWikis.Text = wikis[index];
        }
    }
}
