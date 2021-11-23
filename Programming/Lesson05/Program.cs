using System;
using System.Collections.Generic;

namespace Lesson05
{
    public class Program
    {
        private string[,] _map = 
        {
            {"S", "P", "W", "W", "W", "W", "W", "W", "W", "J"},
            {"W", "P", "P", "P", "P", "P", "P", "W", "W", "J"},
            {"W", "W", "W", "W", "W", "W", "P", "W", "W", "J"},
            {"W", "W", "W", "W", "W", "W", "P", "W", "W", "J"},
            {"W", "W", "W", "W", "W", "W", "P", "W", "W", "J"},
            {"W", "W", "W", "W", "W", "W", "P", "W", "W", "J"},
            {"W", "W", "W", "W", "W", "W", "P", "W", "W", "J"},
            {"W", "W", "W", "W", "W", "W", "P", "P", "W", "J"},
            {"W", "W", "W", "W", "W", "W", "W", "P", "W", "J"},
            {"W", "W", "W", "W", "W", "W", "W", "P", "P", "E"},
        };
        private int _x = 0;
        private int _y = 0;
        
        private int _userStartChoice;
        private int _userGameChoice;

        private void PrintMap()
        {
            string message = "";

            foreach (var y in _map)
            {
                switch (y)
                {
                    case "S":
                        message += "S ";
                        break;
                    case "W":
                        message += "■ ";
                        break;
                    case "P":
                        message += "P ";
                        break;
                    case "E":
                        message += "E\n";
                        break;
                    case "J":
                        message += "■\n";
                        break;
                }
                
            }

            Console.WriteLine(message);
        }

        private void Game()
        {
            while (_userGameChoice != 5)
            {
                PrintMap();
                
                Console.WriteLine("1) Up");
                Console.WriteLine("2) Down");
                Console.WriteLine("3) Left");
                Console.WriteLine("4) Right");
                Console.WriteLine("5) Exit");
                Console.Write("Your choice: ");
                
                try
                {
                    _userGameChoice = Convert.ToInt32(Console.ReadLine());
                    switch (_userGameChoice)
                    {
                        case 1:
                            if (_map[_x, _y + 1] == "W")
                            {
                                Console.WriteLine("Theres a wall there!");
                            }
                            else
                            {
                                _y += 1;
                                _map[_x, _y] = 
                                Console.WriteLine("You moved up one space.");
                            }
                            
                            break;
                        case 2:
                            Game();
                            break;
                        case 3:
                            Game();
                            break;
                        case 4:
                            Game();
                            break;
                        case 5:
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
            
        private void main()
        {
            Console.WriteLine("Welcome!");
            
            while (_userStartChoice != 2)
            {
                Console.WriteLine("1) Start");
                Console.WriteLine("2) Exit");
                Console.Write("Your choice: ");
                
                try
                {
                    _userStartChoice = Convert.ToInt32(Console.ReadLine());
                    switch (_userStartChoice)
                    {
                        case 1:
                            Game();
                            break;
                        case 2:
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
            new Program().main();
        }
    }
}