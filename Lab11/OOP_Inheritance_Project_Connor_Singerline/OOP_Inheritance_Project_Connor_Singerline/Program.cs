using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Project_Connor_Singerline
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Savings
            decimal totalC = 0.00m;
            SavingsAccount savings = new SavingsAccount(100000.00M, 0.05M);
            
            savings.InterestRate = 0.05M;
            Console.WriteLine($"The savings account balance is {savings.Balance} and interest rate is {savings.InterestRate}.");

            totalC = savings.CalculateInterest();
            Console.WriteLine($"The interest is equal to {totalC}");

            savings.Credit(totalC);

            Console.WriteLine($"The final balance is equal to {savings.Balance}");
            // Testing Checking

            CheckingAccount checking = new CheckingAccount(100.00M, 2.50M);
            checking.Fee = 2.5M;
            Console.WriteLine("We will now test the checking account.");
            Console.WriteLine($"The checking account balance is {checking.Balance} and the fee is {checking.Fee}");
            //add money
            checking.Credit(50.00M);
            Console.WriteLine($"We added $50 to checking, new balance is {checking.Balance}");
            checking.Debit(1.00M);
            Console.WriteLine("We now debited $2 from the checking account, note that their is a $2.50 fee.");
            Console.WriteLine($"Final checking account balance = {checking.Balance}");
            Console.ReadLine();

        }
    }
}
