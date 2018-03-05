using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }
            Console.ReadLine();
        }

    }
}


//{
//            int i = 10;
//            while (i< 21)
//            {
//                Console.WriteLine(i);
//                i++;
//            }
//            Console.ReadLine();
//        }



    
//        static void Main(string[] args)
//{
//    for (int i = 1; i <= 100; ++i)
//    {
//        if ((i % 2) == 0)
//        {
//            Console.Write($"{i} even ");
//        }
//        else
//        {
//            Console.Write($"{i} odd ");
//        }
//    }
//    Console.ReadLine();
////}

//{
//            Console.WriteLine("Please enter a temperature");
//            int temp = Convert.ToInt32(Console.ReadLine());
//            if (temp< 10)
//            {
//                Console.WriteLine("Polar Bear");
//            }
//            else if (temp< 20)
//            {
//                Console.WriteLine("Penguin");
//            }
//            else if (temp< 40)
//            {
//                Console.WriteLine("Moose");
//            }
//            else if (temp< 50)
//            {
//                Console.WriteLine("Reindeer");
//            }
//            else if (temp< 60)
//            {
//                Console.WriteLine("Deer");
//            }
//            else if (temp< 70)
//            {
//                Console.WriteLine("Turtle");
//            }
//            else if (temp< 80)
//            {
//                Console.WriteLine("Lion");
//            }
//            else if (temp< 90)
//            {
//                Console.WriteLine("Fish");
//            }
//            else
//            {
//                Console.WriteLine("Bug");
//            }
//        }  