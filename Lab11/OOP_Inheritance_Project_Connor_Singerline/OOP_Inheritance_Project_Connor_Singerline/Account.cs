using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Project_Connor_Singerline
{
    class Account
    {
        //variables
        private decimal _balance;

        //constructors
        public Account(decimal _balance)
        {
            Balance = _balance;
        }

        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                    _balance = value;
                else
                    throw new Exception("Balance needs to be zero or greater"); 
            }
        }

        //Credit and Debit current balance
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                throw new Exception("Credit must be a positive number");
        }

        public virtual bool Debit(decimal amount)
        {
            bool good = true;
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                good = true;
            } 
            else
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                good = false;
            }
            return good;
        }
    }
}
