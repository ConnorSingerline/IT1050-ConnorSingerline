using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Project_Connor_Singerline
{
    class SavingsAccount : Account
    {
        // 
        private decimal _interestRate;

        public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
        {
            InterestRate = _interestRate;
        }
    
        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value >= 0)
                
                    _interestRate = value;
                
                else
                    throw new Exception("The interest rate must be more than zero.");
            }
        }

        //method
        public decimal CalculateInterest()
        {
            return Balance * _interestRate;
        }
    }
}
