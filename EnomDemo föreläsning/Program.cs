using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo_föreläsning
{
    enum Beverage 
    { 
         Coffee,
         Tea,
         Water,
         Soda,
         Juice,
    
    }


    internal class Program
    {




        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Which drink would you like? (Coffee, Tea, Water, Soda, Juice");
            string userInput = Console.ReadLine();  
            
            switch (userInput.ToLower()) 
            {
                case "coffee":
                    respond(Beverage.Coffee);
                    break;
                case "tea":
                    respond(Beverage.Tea);
                    break;
                case "water":
                    respond(Beverage.Water);    
                    break;
                case "soda":
                    respond(Beverage.Soda);
                    break;
                case "juice":
                    respond(Beverage.Juice);
                    break;
                default:
                    Console.WriteLine("Drink does not exist");
                    break;
            }
            Console.ReadKey();  
        }
        static void respond (Beverage drink) 
        {
            switch (drink)

            { 
                    case Beverage.Coffee:
                         Console.WriteLine("You ordered coffe");
                         break;
                    case Beverage.Tea:
                         Console.WriteLine("You ordered tea");
                         break;
                    case Beverage.Water:
                    Console.WriteLine("You ordered water");
                         break;
                    case Beverage.Soda:
                         Console.WriteLine("You ordered soda");
                         break;
                    case Beverage.Juice:
                         Console.WriteLine("You orderd Juice");
                         break;   
                    
            }
        }
    }
}
