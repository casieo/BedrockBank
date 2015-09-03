using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    /// <summary>
    /// This class defines the account
    /// </summary>
    class Account
    {
        #region Variables
        /// <summary>
        /// This will create static shared memory
        /// </summary>
        private static int lastAccountNumber=0;
        #endregion
        #region Properties
        /// <summary>
        /// Account Number property
        /// </summary>
        public int AccountNumber { get; private set; }
        ///Balance property
        public double Balance {
            get
            {
                return balance;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Not sufficient fund!!");
                }
                balance = value;
            }
        }
        /// Account holder's name
        public string AccountHolderName { get; set; }
        /// Account holder SSN
        public int SSN { get; set; }
        #endregion
        #region Constructors
        /// <summary>
        /// This is the default constructor.  This was hidden before, now I'm just exposing it so I can modify it
        /// </summary>
      

        public Account()
        {
            AccountNumber = lastAccountNumber + 1;
            lastAccountNumber = AccountNumber;
            //Alternatively: AccountNumber=++lastAccountNumber; ++ means increment by 1.  Can do pre increment or post increment.  Preincrement: =++, postincrement: =lastnumber++
        }

        public Account(string name)
        {
            AccountNumber = lastAccountNumber + 1;
            lastAccountNumber = AccountNumber;
            AccountHolderName = name;
            //Alternatively: AccountNumber=++lastAccountNumber; ++ means increment by 1.  Can do pre increment or post increment.  Preincrement: =++, postincrement: =lastnumber++
        }
        #endregion

        #region Methods

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
            //Or, could say Balance+=amount;
        }
        public bool Withdraw(double amount)
        {
            if (amount > Balance)
            {
                return false;
            }
            Balance -= amount;
            return true;
        }
        #endregion
    }
}
