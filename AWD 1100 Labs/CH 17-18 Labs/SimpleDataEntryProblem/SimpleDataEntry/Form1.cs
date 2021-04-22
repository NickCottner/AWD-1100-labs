using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleDataEntry
{
    public partial class FormDataEntry : Form
    {
        public FormDataEntry()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string outputStr = "";
            bool keepGoing = fieldExists(txtFirstName);

            if (keepGoing)
            {
                keepGoing = fieldExists(txtLastName);
            }
            else
            {
                return;
            }
            if (keepGoing)
            {
                keepGoing = fieldExists(txtAddress);
            }
            else
            {
                return;
            }
            if (keepGoing)
            {
                keepGoing = fieldExists(txtCity);
            }
            else
            {
                return;
            }
            if (keepGoing)
            {
                keepGoing = fieldExists(txtState);
            }
            else
            {
                return;
            }
            if (keepGoing)
            {
                keepGoing = fieldExists(txtZipCode);
            }
            else
            {
                return;
            }
            if (keepGoing)
            {
                outputStr = txtFirstName.Text + " " +
                            txtLastName.Text + "\r\n" +
                            txtAddress.Text + "\r\n" +
                            txtCity.Text + ", " +
                            txtState.Text + " " +
                            txtZipCode.Text;

                MessageBox.Show(outputStr, "INPUT CONTENTS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
        }
        private bool fieldExists(TextBox tb)
        {
            if (tb.Text == "")
            {
                showMessage("The entry for textbox " + tb.Tag + " is missing",
                            "MISSING INPUT FOR FIELD " + tb.Tag);
                tb.Focus();
                return false;
            }
            return true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtFirstName.Text = " ";
            txtLastName.Text = " ";
            txtAddress.Text = " ";
            txtCity.Text = " ";
            txtState.Text = " ";
            txtZipCode.Text = " ";
            txtFirstName.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Exit?", "EXIT NOW?",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void textboxInputs_KeyPress(object sender, KeyPressEventArgs e)
        {
            string textBoxSender = ((TextBox)sender).Name;

            if (e.KeyChar == 13)
            {
                switch (textBoxSender)
                {
                    case "txtFirstName":
                        txtLastName.Focus();
                        break;

                    case "txtLastName":
                        txtAddress.Focus();
                        break;

                    case "txtAddress":
                        txtCity.Focus();
                        break;

                    case "txtCity":
                        txtState.Focus();
                        break;

                    case "txtState":
                        txtZipCode.Focus();
                        break;

                    case "txtZipCode":
                        buttonEnter.Focus();
                        break;
                }
            }
            if (textBoxSender.Equals("txtZipCode"))
            {
                if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button_Hover(object sender , EventArgs e)
        {
            ((Button)sender).BackColor = Color.Orchid;
        }
        private void button_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = SystemColors.Control;
        }
     
    }
}
