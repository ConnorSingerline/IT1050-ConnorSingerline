using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_ConnorSingerline
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 9;
            while(i < 20)
            {
                i = i + 1;
                Console.WriteLine($"{i}");
            }
            Console.ReadLine();
        }
    }
}




//LAB04 PART 1
//int speedLimit=35;
//int speed=42;

//if (speed >speedLimit)
//{
//    Console.WriteLine("SLOW NOW");
//    Console.ReadLine();
//}


//LAB04 PART 2
//bool isTrue;
//Console.WriteLine("Type true or false to assign isTrue a value");
//            string response = Console.ReadLine();
//bool.TryParse(response, out isTrue);
//            if (isTrue == true)
//            {
//                Console.WriteLine("It is True!");
//                Console.ReadLine();
//            }
//            else if (isTrue == false)
//            {
//                Console.WriteLine("It is False!");
//                Console.ReadLine();
//            }
//            else
//                Console.WriteLine("Start over, isTrue must be true or false");
//            Console.ReadLine();

////LAB04 PART 3
//Console.WriteLine($"This program will convert Fahrenheit temperature to Celcisu. Please input a Fahrenheit temperature...");
//            double fahrenheit = Convert.ToDouble(Console.ReadLine());
//var celsius = ((fahrenheit - 32d) * 5d / 9d);

//            if (fahrenheit< 40)
//            {
//                Console.WriteLine($"It is cold. The conversion from {fahrenheit} degrees Fahrenheit is equal to {celsius} degrees celcius.");
//                Console.ReadLine();
//            }
//            else if (fahrenheit > 90)
//            {
//                Console.WriteLine($"It is hot. The conversion from {fahrenheit} degrees Fahrenheit is equal to {celsius} degrees celcius.");
//                Console.ReadLine();
//            }
//            else
//                Console.WriteLine($"The conversion from {fahrenheit} degrees Fahrenheit is equal to {celsius} degrees celcius.");
//                Console.ReadLine();


// LAB04 PART 3 -- 
//int i = 0;
//            while(i< 10)
//            {
//                i = i + 1;
//                Console.WriteLine($"{i}");
//            }
//            Console.ReadLine();

//// LAB04 PART 4 - Q6
//int i = 61;
//            while(i > 20)
//            {
//                i = i - 1;
//                Console.WriteLine($"{i}");
//            }
//            Console.ReadLine();