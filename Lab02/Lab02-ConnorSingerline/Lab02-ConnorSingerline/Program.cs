using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_ConnorSingerline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to ");
            Console.WriteLine("C# Programming!");
            Console.ReadLine();

            int a;
            int b;
            Console.WriteLine("We will add two integers together.\n Type the first integer and click enter:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second integer and click enter:");
            b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"The total is: {sum}\n\n");
            Console.WriteLine("Here is a formula (x + y) * (z + 10)\nWe will now assign variables.\nType an integer for x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Type an integer for y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Type an integer for z:");
            int z = int.Parse(Console.ReadLine());
            int sum2 = ((x + y) * (z + 10));
            Console.WriteLine($"\nThe total is: {sum2}\n\n");
            Console.WriteLine("Below is an output of messages using escape sequences.\n\nHello\tWorld!\nHello\nWorld\n\"Hello World!\"\nHello\\World!\n\nClick Enter to close the program.");
            Console.ReadLine();
        }
    }
}
