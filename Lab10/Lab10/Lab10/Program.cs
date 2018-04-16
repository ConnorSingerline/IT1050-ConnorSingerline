using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            Console.WriteLine("Part 1 **********");
            var fruits = new[] { "apple", "mango", "orange", "apricot", "cherry", "grape", "blueberry" };
            foreach (string i in fruits)
            {
                Console.WriteLine(i);
            }

            //Part 2
            Console.WriteLine("Part 2 **********");
            string[] x = fruits.Select(y => y.ToUpper())
                                             .ToArray();
            var findStartsWithA = from element in x
                       where element.StartsWith("A")
                        select element;
            foreach (string e in findStartsWithA)
            {
                Console.WriteLine(e);
            }
            //Part 3
            Console.WriteLine("Part 3 **********");
            List<string> months = new List<string>();
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");
            Console.WriteLine("the List has {0} count and {1} capacity",  months.Count, months.Capacity);
            for (int i = 0; i < 1; i++)
            {
                months.ForEach(Console.WriteLine);
            }
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            Console.WriteLine("Months in correct order ****");
           int r = 6;
            for (int i = 0; i < 12; i++)
            {
                if(r == 12)
                {
                    r = 0;
                }
                Console.WriteLine(months[r]);
                r++;
            }
            //Part 4
            Console.WriteLine("Part 4 **********");
            months.RemoveAt(0);
            months.RemoveAt(0);
            months.RemoveAt(0);
            months.RemoveAt(0);
            months.RemoveAt(0);
            months.RemoveAt(0);

            Console.WriteLine("the List has {0} count and {1} capacity", months.Count, months.Capacity);
            var findEndsWithAry = from element in months
                                  where element.EndsWith("ary")
                                  select element;
            foreach (string e in findEndsWithAry)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
