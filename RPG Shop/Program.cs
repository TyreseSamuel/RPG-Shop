using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Shop
{
    class Program
    {
        static float gold = 0.00f;
        static string choice = "";
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1: Add Gold");
                Console.WriteLine("2: Buy Bulma");
                Console.WriteLine("3: Buy Icarus");
                Console.WriteLine("4: Buy Senzu Bean");
                Console.WriteLine("5: Exit");
            }

        }
    }
}
