using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobDatabase
{
    public partial class FormJD : Form
    {
        public FormJD()
        {
            InitializeComponent();
        }

        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxJobs.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var m = new FormSr();
            m.Show();
            this.Hide();
        }
    }
}
