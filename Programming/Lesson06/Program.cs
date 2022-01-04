using System;

namespace Lesson06 {
    public class Program {
        
        private double _endHeight;
        private double _startHeight;
        private int _bounces;
        private double _heightLost;
        
        private int _choice;

        private void Calculate() {
            Console.WriteLine("What is the end height: ");
            _endHeight = Convert.ToDouble(Console.ReadLine());
            _startHeight = _endHeight;

            Console.WriteLine("How many bounces: ");
            _bounces = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much height is lost on every bounce:");
            _heightLost = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < _bounces; i++) {
                _startHeight += _heightLost;
            }

            Console.WriteLine($"The start height would be: {_startHeight}\n");
        }
        
        private void Bounce() {
            Console.WriteLine("Welcome!");
            
            while (_choice != 2) {
                Console.WriteLine("1) Start");
                Console.WriteLine("2) Exit");
                Console.Write("Your choice: ");
                
                try {
                    _choice = Convert.ToInt32(Console.ReadLine());
                    switch (_choice) {
                        case 1:
                            Calculate();
                            break;
                        case 2:
                            Console.WriteLine("Cya!");
                            break;
                        default:
                            Console.WriteLine("That was not a valid choice.");
                            break;
                    }
                }
                catch (InvalidCastException) {
                    Console.WriteLine("That was not a valid choice.");
                }
            }
        }
        
        private static void Main(string[] args) {
            new Program().Bounce();
        }
    }
}