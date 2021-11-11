using System;
using System.Collections.Generic;

namespace Lesson03
{
    class Program
    {
        private int _gold = 100;
        private Dictionary<string, int> _items = new Dictionary<string, int>()
        {
            {"Golden shovel", 20},
            {"Forbidden stick", 80},
            {"Unknown creatures severed horn", 2},
        };

        private string BuyItem(string item)
        {
            if (_items[item] > _gold)
            {
                return "You don't have enough gold pieces to buy that item.\n";
            }
            _gold -= _items[item];
            return $"You bought '{item}', you now have {_gold} gold pieces remaining.\n";
        }

        private void NpcShop()
        {
            Console.WriteLine("Welcome to my shop!!!");
            
            while (_gold > 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"1) Golden shovel - {_items["Golden shovel"]} GP");
                Console.WriteLine($"2) Forbidden stick - {_items["Forbidden stick"]} GP");
                Console.WriteLine($"3) Unknown creatures severed horn - {_items["Unknown creatures severed horn"]} GP");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"You have {_gold} gold pieces, please select the number of the item you would like to buy:");
                try
                {
                    var choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(BuyItem("Golden shovel"));
                            break; 
                        case 2:
                            Console.WriteLine(BuyItem("Forbidden stick"));
                            break;
                        case 3:
                            Console.WriteLine(BuyItem("Unknown creatures severed horn"));
                            break;
                        default:
                            Console.WriteLine("That was not a valid choice.\n");
                            break;
                    }
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("That was not a valid choice.");
                }
            }
            Console.WriteLine("Oh no! Your gold! It ran out!");
        }
        
        private static void Main(string[] args)
        {
            new Program().NpcShop();
        }
    }
}