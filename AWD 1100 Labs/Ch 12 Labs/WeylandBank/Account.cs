using System;
using System.Windows.Forms;

namespace WeylandBank
{
    class Account
    {
        //Create a constant
        public decimal MINBALANCE = 25.00m;

        //Instance Variables
        private readonly string _Title;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _accountNumber;
        private readonly string _pin;
        private decimal _balance;

        public Account(string title, string firstName, string lastName,
                       string accountNumber, string pin, decimal balance)
        {
            _Title = title;
            _firstName = firstName;
            _lastName = lastName;
            _accountNumber = accountNumber;
            _pin = pin;
            _balance = balance;
        }

        //Getters
        public string GetTitle()
        {
            return _Title;
        }
        public string GetFirstName()
        {
            return _firstName;
        }
        public string GetLastNAme()
        {
            return _lastName;
        }
        public string GetAccountNumber()
        {
            return _accountNumber;
        }
        public string GetPin()
        {
            return _pin;
        }
        public decimal GetBalance()
        {
            return _balance;
        }

        public void MakeDeposit(decimal deposit)
        {
            decimal theDeposit = -1m;

            try
            {
                //Attempt to make deposit
                theDeposit = deposit;

                //check for a 0 or negative deposit
                if (theDeposit <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                //Valid Deposit
                _balance += deposit;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Illegal Deposit (0 or Negative Amount) Attempted!",
                                     "ILLEGAL DEPOSIT ATTEMPTED!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }
        public void MakeWithdrawal(decimal withdrawal)
        {
            decimal theWithdrawal = withdrawal;
            decimal temp = -1;

            
            try
            {
                decimal theAmount = withdrawal;

                if (theWithdrawal <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                temp = _balance - theWithdrawal;

                if (temp >= MINBALANCE)
                {
                    _balance = withdrawal;
                }
                else
                {
                    MessageBox.Show("Illegal Withdrawal. The attempted withdrawal would " +
                                     "leave the account with < the minimum balance of:" + 
                                     MINBALANCE.ToString("c"), "ILLEGAL WITHDRAWAL ATTEMPTED!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
                    
                      
                
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Illegal Withdrawal (0 or Negative Amount) Attempted!",
                                     "ILLEGAL Withdrawal!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
            
        }
        
    }
}
