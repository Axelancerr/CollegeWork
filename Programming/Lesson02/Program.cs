using System;
using System.Runtime.InteropServices.ComTypes;

namespace Lesson02
{
    class Program
    {
        private static void Activity01()
        {
            Console.WriteLine("Choose a number, 1, 2, or 3:");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1: 
                    Console.WriteLine("Starting the game!");
                    Activity02();
                    break;
                case 2: 
                    Console.WriteLine("Opening the settings!");
                    break;
                case 3: 
                    Console.WriteLine("Exiting the game!");
                    break;
                default:
                    Console.WriteLine("ERROR! INVALID ENTRY!");
                    break;
            }
        }
        private static void Activity02()
        {
            int playerHealth = 20;
            int spiderHealth = 10;
            const int playerDamage = 5;
            const int spiderDamage = 5;
            
            Console.WriteLine("A spider has appeared! Do you want to attack? (Y/N): ");
            switch (Console.ReadLine().ToUpper())
            {
                case "Y":
                    spiderHealth -= playerDamage;
                    Console.WriteLine($"You attacked, the spiders health is now {spiderHealth}");
                    break;
                case "N":
                    playerHealth -= spiderDamage;
                    Console.WriteLine($"The spider attacked you! Your health is now {playerHealth}");
                    break;
                default:
                    Console.WriteLine("That wasn't a valid option.");
                    break;
            }
        }
        
        private static void Main(string[] args)
        {
            Activity01();
        }
    }
}
