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
           BURGER = 1, PIZZA, STEAK, FRIES, EXIT

        }
        static void Main(string[] args)
        {
            int foodMenu = 0;
            string prompt;
            while (foodMenu != 5)
            {
                




                Console.WriteLine("WELCOME TO MARK'S RESTAURANT!! ");
                Console.WriteLine();
                Console.WriteLine("This is our Menu:");
                Console.WriteLine("__________________________________________________________________________");
                Console.WriteLine("1 - Burger");
                Console.WriteLine("2 - Pizza");
                Console.WriteLine("3 - Steak");
                Console.WriteLine("4 - Fries");
                Console.WriteLine("5 - Exit");
                Console.Write("Enter your order here! (1 to 5): ");
                prompt = Console.ReadLine();
                Console.Write("\n");
                foodMenu = Convert.ToInt32(prompt);
               

                Console.WriteLine("__________________________________________________________________________");
                Console.WriteLine();
                switch ((Menu)foodMenu)
                {
                    case Menu.BURGER:
                        Console.WriteLine("You want are now eating burger?");
                        break;
                    case Menu.PIZZA:
                        Console.WriteLine("You like italian food?");
                        break;
                    case Menu.STEAK:
                        Console.WriteLine("Steak is the best choice.");
                        break;
                    case Menu.FRIES:
                        Console.WriteLine("You are trying to save money");
                        break;
                    case Menu.EXIT:
                        Console.WriteLine("Thank you for choosing our restaurant! please come again!");
                        break;
                    default:
                        Console.WriteLine("ERROR - Invalid Entry!!");
                        break;
                        
                }
                Console.WriteLine("__________________________________________________________________________");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }


            Console.WriteLine("__________________________________________________________________________");
           Console.WriteLine("Press any key to exit...");
           Console.ReadKey();

        }
    }
}
