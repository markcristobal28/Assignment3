using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    class Program
    {
        enum Menu
        {
            Burger =  1, 

        }
        static void Main(string[] args)
        {
            int foodMenu;
            string prompt;
            

            Console.WriteLine("Q1. What do you wanna eat?: ");
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("1 - Burger");
            Console.WriteLine("2 - Pizza");
            Console.WriteLine("3 - Steak");
            Console.WriteLine("4 - Fries");
            Console.Write("Please make your selection (1 to 4): ");
            prompt = Console.ReadLine();
            Console.Write("\n");
           foodMenu = Convert.ToInt32(prompt);

        }
    }
}
