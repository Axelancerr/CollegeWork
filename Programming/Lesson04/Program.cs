using System;

namespace Lesson04
{
    public class Program
    {
        private int _fishAmount = 0;
        private int _userInput;
        
        private void Fishing()
        {
            Console.WriteLine("Welcome!");
            
            while (_userInput != 3)
            {
                Console.WriteLine("What would you like to do? ");
                Console.WriteLine("1) Catch");
                Console.WriteLine("2) Sell");
                Console.WriteLine("3) Exit");
                
                try
                {
                    _userInput = Convert.ToInt32(Console.ReadLine());
                    switch (_userInput)
                    {
                        case 1:
                            Console.WriteLine("Fish caught!");
                            _fishAmount += 1;
                            Console.WriteLine($"You now have {_fishAmount} fish!");
                            break;
                        case 2:
                            Console.WriteLine("A");
                            break;
                        case 3:
                            Console.WriteLine("Cya!");
                            break;
                        default:
                            Console.WriteLine("That was not a valid choice.");
                            break;
                    }
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("That was not a valid choice.");
                }
            }
        }
        
        private static void Main(string[] args)
        {
            new Program().Fishing();
        }
    }
}
