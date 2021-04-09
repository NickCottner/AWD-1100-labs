using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeylandBank
{
    public partial class FormWeylandBank : Form
    {
        public FormWeylandBank()
        {
            InitializeComponent();
        }
        //Constants
        const int NUMCUSTOMERS = 5;

        //Global Variables
        List<Account> accounts = new List<Account>();

        int validAccountNumLoc = -1;
        int validPinNumLoc = -1;
        bool yourLogIn = false;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            bool missingInfo = true; //Program continue variable 1
            bool badAccNumber = true; //Program continue variable 2
            bool badPinNumber = true; //Program continue variable 3

            missingInfo = isAnyLoginInfoMissing();

            if (missingInfo)
            {
                return;
            }

            //If reach this point both the account number and pin number
            //textboxes were filled in. Now validate each one.

            badAccNumber = validateAccountNumber(textBoxAccountNumber.Text);

            badPinNumber = validatePinNumber(textBoxPinNumber.Text);

            if ((badAccNumber) || (badPinNumber))
            {
                displayBadAccountNumberOrPinNumberMessage();
                return;
            }

            if (validAccountNumLoc != validPinNumLoc)
            {
                displayBadAccountNumberOrPinNumberMessage();
                return;
            }

            //Valid account number and valid pin number
            rewriteWelcomeScreen();
            makeScreenActive();
        }
        public void makeScreenActive()
        {
            //Log in the current user
            yourLogIn = true;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            buttonDeposit.Enabled = true;
            buttonWithdrawal.Enabled = true;
        }
        private bool isAnyLoginInfoMissing()
        {
            textBoxWelcomeInfo.Text = "";
            string missingLoginStr = "";
            missingLoginStr += "\r\nAccount Number and Pin Number both mandatory for login.";
            missingLoginStr += "\r\n\r\nAccount # entered as nnnnnnnnn where each n is a number.";
            missingLoginStr += "\r\n\r\nThe Pin # Entered as nnnn where each n is a number.\n";
            missingLoginStr += "\r\n\r\nPlease try again and enter both values.";

            if ((textBoxAccountNumber.Text.Trim() == "") || (textBoxPinNumber.Text.Trim() == ""))
            {
                textBoxWelcomeInfo.Text = "";
                textBoxWelcomeInfo.Text = missingLoginStr;

                clearLoginFields();
                return true;

            }

            return false;
        }

        //THis method is called to validate the inputted account number.
        //This number must exist in the account number ArrayList.
        private bool validateAccountNumber(string an)
        {
            validAccountNumLoc = -1;

            for (int lcv = 0; lcv < accounts.Count; ++lcv)
            {
                if (an == accounts[lcv].GetAccountNumber())
                {
                    validAccountNumLoc = lcv;
                    return false;
                }
            }

            return true;
        }

        //THis method is called to validate the inputted pin number.
        //This number must exist in the pin number ArrayList.
        private bool validatePinNumber(string pn)
        {
            validPinNumLoc = -1;

            for (int lcv = 0; lcv < accounts.Count; ++lcv)
            {
                if (pn == accounts[lcv].GetPin())
                {
                    validPinNumLoc = lcv;
                    return false;
                }
            }

            return true;
        }

        //This method is called if either the account # or the pin # inputted
        //was not in the ArrayList.
        private void displayBadAccountNumberOrPinNumberMessage()
        {
            string wrongLoginStr = "";
            wrongLoginStr += "Bad Account Number and/or Bad Pin Number Entered!";
            wrongLoginStr += "\r\n\r\nPlease reenter your info now.";

            textBoxWelcomeInfo.Text = "";
            textBoxWelcomeInfo.Text = wrongLoginStr;

            clearLoginFields();
        }

        //This method is called to clear out both the Account # and Pin # textboxes.
        private void clearLoginFields()
        {
            textBoxAccountNumber.Text = "";
            textBoxPinNumber.Text = "";
            textBoxAccountNumber.Focus();
        }

        //If we get here, the user entered both a valid Account # and a valid Pin #.
        //So, show the user a welcome message.
        //along witht their balance info.
        private void rewriteWelcomeScreen()
        {
            string welcomeStr = "Welcome ";
            welcomeStr += accounts[validPinNumLoc].GetTitle() + " ";
            welcomeStr += accounts[validPinNumLoc].GetFirstName() + " ";
            welcomeStr += accounts[validPinNumLoc].GetLastNAme() + ",";
            welcomeStr += "\r\n\r\nYour current balance is: " + " ";
            welcomeStr += accounts[validPinNumLoc].GetBalance().ToString("c") + ".";

            textBoxWelcomeInfo.Text = welcomeStr;
            buttonLogin.Enabled = false;
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            bool keepGoing = loggedInOrNot();

            if (keepGoing)
            {
                attemptTheDeposit();
                return;
            }
            
        }

        //THis method attempts the deposit into the
        //person's bank account. It is called by the
        //Deposit button click event.
        public void attemptTheDeposit()
        {
            decimal deposit;

            try
            {
                deposit = Convert.ToDecimal(textBoxDeposit.Text);
                accounts[validPinNumLoc].MakeDeposit(deposit);
                rewriteWelcomeScreen();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void buttonWithdrawal_Click(object sender, EventArgs e)
        {
            bool keepGoing = loggedInOrNot();

            if (keepGoing)
            {
                attemptTheWithdrawal();
                return;
            }
        }
        //THis method attempts the withdrawal from the
        //person's bank account. It is called by the
        //Withdraw button click event.
        public void attemptTheWithdrawal()
        {
            decimal withdrawal;

            try
            {
                withdrawal = Convert.ToDecimal(textBoxWithdrawal.Text);
                accounts[validPinNumLoc].MakeWithdrawal(withdrawal);
                rewriteWelcomeScreen();
            }
            catch (Exception)
            {
                return;
            }
        }
        //If the user is not logged in, s\he cannot
        //perform a deposit or withdrawal.
        private bool loggedInOrNot()
        {
            if (!yourLogIn)
            {
                textBoxWelcomeInfo.Text = "You are not logged in so you cannot make a transaction";
                return false;
            }

            return true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
        //This method will let the user end the program.
        //It is called Logout button.
        private void Logout()
        {
            // Prompt the user to see if s\he really wants to end the program
            if (MessageBox.Show("Do You Really Want To Logout?", "LOGOUT NOW?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Blank out the current screen
                blankOutAllThingsOnScreen();

                //logout the current user
                yourLogIn = false;
                buttonLogin.Enabled = true;
                buttonLogout.Enabled = false;
                buttonDeposit.Enabled = false;
                buttonWithdrawal.Enabled = false;
                textBoxAccountNumber.Focus();
            }
        }

        // This method will "blank out" the screen.
        public void blankOutAllThingsOnScreen()
        {
            textBoxWelcomeInfo.Enabled = false;
            textBoxDeposit.Text = " ";
            textBoxWithdrawal.Text = " ";
            textBoxAccountNumber.Text = " ";
            textBoxPinNumber.Text = " ";
            textBoxAccountNumber.Focus();
        }

        private void FormWeylandBank_Load(object sender, EventArgs e)
        {
            accounts.Add(new Account("Ms.", "Megan", "Ptak", "123-456-789", "3456", 10000M));
            accounts.Add(new Account("Mr.", "Bob", "Deadry", "234-567-890", "8754", 2500.00M));
            accounts.Add(new Account("Mr.", "Paul", "Bunyon", "345-678-901", "6543", 13456.78M));
            accounts.Add(new Account("Ms.", "Shannon", "Morningstar", "456-789-012", "2049", 5678.90M));
            accounts.Add(new Account("Mr.", "Nick", "Cottner", "567-890-123", "4190", 100456.21M));

        }
    }
}

