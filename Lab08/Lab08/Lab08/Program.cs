using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                i++;
            }
            Console.ReadLine();
        }
    }
}


//ANSWER TO ALL QUESTIONS BELOW:





//QUESTION 1
//namespace Lab08
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
//            Console.WriteLine(names[1] + " " + names[4]);
//            Console.ReadLine();
//        }
//    }
//}


//QUESTION 2
//namespace Lab08
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int num = 1;
//            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
//            foreach (string i in months)
//            {
//                Console.Write($"{num} ");
//                System.Console.WriteLine("{0} ", i);
//                ++num;
//            }
//            Console.ReadLine();
//        }
//    }
//}


//QUESTION 3
//namespace Lab08
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
//            foreach (string i in seasons)
//            {
//                System.Console.WriteLine("{0} ", i);
//            }
//            Console.ReadLine();
//        }
//    }
//}


//QUESTION 4
//namespace Lab08
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int counter = 1;
//            int[] integers = new int[1000];
//            Random random = new Random();
//            int randomNumber;
//            for (int i = 0; i < integers.Length; i++)
//            {
//                randomNumber = random.Next(0, 100);
//                integers[i] = randomNumber;
//            }
//            foreach (int i in integers)
//            {
//                Console.Write($"({counter}) ");
//                System.Console.WriteLine("{0} ", i);
//                counter++;
//            }
//            Console.ReadLine();
//        }
//    }
//}

//QUESTION 5
//namespace Lab08
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
//            int i = 0;
//            while (i < names.Length)
//            {
//                Console.WriteLine(names[i]);
//                i++;
//            }
//            Console.ReadLine();
//        }
//    }
//}
