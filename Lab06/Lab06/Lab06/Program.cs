using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            int i= 2020;
            int counter = 1;
            while (counter <=20)
            {
                if (counter > 20)
                {
                    Console.WriteLine("Error");
                    Console.ReadLine();
                }
                else
                {

                    Console.WriteLine($"{i}");
                    i = i+ 4;
                    ++counter;
                }
            }
            Console.ReadLine();
        }
    }
}
