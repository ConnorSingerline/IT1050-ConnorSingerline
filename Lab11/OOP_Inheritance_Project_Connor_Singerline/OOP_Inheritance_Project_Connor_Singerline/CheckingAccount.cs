using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Project_Connor_Singerline
{
    class CheckingAccount : Account
    {
        //variable
        private decimal _fee;

        //constructor
        public CheckingAccount(decimal balance, decimal fee) : base(balance)
        {
            Fee = _fee;
        }

        public decimal Fee
        {
            get { return _fee; }
            set
            {
                if (value >= 0)
                {
                    _fee = value;
                }
                else
                    throw new Exception("Fee must be more than zero.");
            }
        }

        //
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;

        }

        public override bool Debit(decimal amount)
        {
            //if (base.Debit(amount))
            //{
            //    base.Debit(amount);
            //    Balance -= Fee;
            //    return amount;
            //}
            if (base.Debit(amount))
            {
               Balance -= Fee;
                return base.Debit(amount); 
            }
            return false;
            


            //if (base.Debit(amount) == false)
            //{
            //    return false;
            //}
            //Balance -= Fee;
            //return base.Debit(amount);
        }
    }
}
