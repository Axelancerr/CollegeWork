using System;
using Lesson07.enemies;

namespace Lesson07 {
    
    public class Program
    {
        private static bool _isRunning = true;
        private readonly Random _random = new Random();
        
        public static BaseEnemy Enemy;
        public static int Health = 20;
        
        private void SetRandomEnemy()
        {
            var random = _random.Next(0, 1);
            Enemy = random switch
            {
                0 => Enemy = new Skeleton(),
                1 => Enemy = new Zombie(),
                _ => throw new IndexOutOfRangeException("Something went wrong!")
            };
        }

        private void MainLoop()
        {
            if (Health <= 0)
            {
                Console.WriteLine("You ran out of health and died :(" +
                                  "\n");
                Console.WriteLine("Would you like to restart? (y/n)");
                var restart = Console.ReadLine();
                if (restart == "y")
                {
                    Console.WriteLine("Restarting game..." +
                                      "\n");
                    new Program().MainLoop();
                }
                else
                {
                    _isRunning = false;
                    return;
                }
            }
            
            SetRandomEnemy();
            
            var choice = Console.ReadLine();
            if (choice?.ToLower() == "exit")
            {
                Console.WriteLine("You exited the game, cya later!");
                _isRunning = false;
            } else if (Health <= 0)
            {
                Console.WriteLine("You ran out of health and died :(");
            } else
            {
                Console.WriteLine($"You chose: {choice}");
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my game!");
            Console.WriteLine("You can type 'exit' at any time to leave the game.\n");
            
            while (_isRunning)
            {
                new Program().MainLoop();
            }
        }
    }
    
}