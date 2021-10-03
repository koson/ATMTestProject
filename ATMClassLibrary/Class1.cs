using System;

namespace ATMClassLibrary
{
    // class under test
    public class ATMClass
    {
        public int Balance { get; set; }

        public bool Deposit(int depositAmount)
        {
            bool result = false;
            if (depositAmount > 0)
                result = true;
            return result;
        }

        public bool Withdraw(int withdrawAmount)
        {
            bool result = false;
            if (withdrawAmount < Balance)
                result = true;
            if (withdrawAmount <= 0)
                result = false;
            return result;
        }
    }
}
