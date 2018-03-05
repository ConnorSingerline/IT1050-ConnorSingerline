using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            int total = 0;
            List<string> groceryList = new List<string>();
            Console.WriteLine("Welcome to the grocery store.");
            while (text != "E")
            {
                Console.WriteLine("Please enter an item: ");
                string item = Console.ReadLine();
                groceryList.Add(item);
                Console.WriteLine("Please enter the item cost:");
                int cost = Convert.ToInt32(Console.ReadLine());
                total = total + cost;
                Console.WriteLine("Type another item to continue or E to complete.");
            }
            
            foreach(var item in groceryList)
            {
                Console.WriteLine(item.groceryList);
            }

            // I completed until here due to needing to study for an interview 
            // Hopefully partial credit
        }
    }
}
