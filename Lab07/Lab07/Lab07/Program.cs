using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath myMath = new MyMath();
            Console.WriteLine("Multiply: Type an integer to test multiple.");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiply: Type another integer to test multiple.");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            myMath.Multiply(operand1, operand2);
            Console.WriteLine($"result = {myMath.result}");
            Console.WriteLine("Divide: Type an integer to test divide.");
            operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Divide: Type another integer to test divide.");
            operand2 = Convert.ToInt32(Console.ReadLine());
            myMath.Divide(operand1, operand2);
            Console.WriteLine($"result = {myMath.result}");
            Console.WriteLine("Add: Type an integer to test add.");
            operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add: Type another integer to test add.");
            operand2 = Convert.ToInt32(Console.ReadLine());
            myMath.Add(operand1, operand2);
            Console.WriteLine($"result = {myMath.result}");
            Console.WriteLine("Subtract: Type an integer to test subtract.");
            operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subtract: Type another integer to test subtract.");
            operand2 = Convert.ToInt32(Console.ReadLine());
            myMath.Subtract(operand1, operand2);
            Console.WriteLine($"result = {myMath.result}");
            Console.ReadLine();
        }
    }
}
