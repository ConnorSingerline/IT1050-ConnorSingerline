using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNum = new Random();
            int num = ranNum.Next(1, 50);
            Console.WriteLine($"Welcome to the number guessing game. Enter a guess! - Answer: {num}");
            int guess = 0;
            while (guess != num)
            {
                guess = Convert.ToInt32(Console.Read());
                if (guess < num)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                }
                else
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                }
            }
            Console.WriteLine($"Correct! {num} is the correct number.");
        }
    }
}
