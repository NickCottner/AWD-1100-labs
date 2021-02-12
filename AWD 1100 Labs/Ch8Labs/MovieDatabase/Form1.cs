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

        string[] name = { };

        string[] director = { };

        string[] description = { };


        private void labeltheName_Click(object sender, EventArgs e)
        {

        }
    }
}
