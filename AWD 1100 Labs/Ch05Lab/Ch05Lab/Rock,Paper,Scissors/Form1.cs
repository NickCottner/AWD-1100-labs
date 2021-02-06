using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class RockPaperScissors : Form
    {
        int rock = 1;
        int paper = 2;
        int scissor = 3;
        const int MIN = 1;
        const int MAX = 3;
        Random ranNumberGenerator = new Random();
         

        public RockPaperScissors()
        {
            InitializeComponent();
            
            
        }

        private void RockPaperScissors_Load(object sender, EventArgs e)
        { }
    }
}
