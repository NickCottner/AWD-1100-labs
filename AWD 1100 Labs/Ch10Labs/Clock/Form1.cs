using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Yellow;
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Yellow;
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Yellow;
        }
        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.Yellow;
        }
        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.Yellow;
        }
        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.Yellow;
        }
        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.Yellow;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightBlue;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightBlue;
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.LightBlue;
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.LightBlue;
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.LightBlue;
        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.LightBlue;
        }
        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.LightBlue;
        }
        private void textBox8_Enter(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.LightBlue;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGray;
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightGray;
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.LightGray;
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.LightGray;
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.LightGray;
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.LightGray;
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.LightGray;
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.LightGray;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                textBox1.Focus();
            }
            if(e.KeyCode == Keys.Right)
            {
                textBox3.Focus();
            }
            if(e.KeyCode == Keys.Down)
            {
                textBox5.Focus();
            }
            if(e.KeyCode == Keys.Left)
            {
                textBox7.Focus();
            }
           
        }
       
    }
}
