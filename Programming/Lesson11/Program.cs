using System;

namespace Lesson11
{
    class Program
    {
        private static void PrintMixMaxDatatypeValues()
        {
            Console.WriteLine($"Min short: {short.MinValue}");
            Console.WriteLine($"Max short: {short.MaxValue}");
            Console.WriteLine($"Min ushort: {ushort.MinValue}");
            Console.WriteLine($"Max ushort: {ushort.MaxValue}");
            
            Console.WriteLine($"Min int: {int.MinValue}");
            Console.WriteLine($"Max int: {int.MaxValue}");
            Console.WriteLine($"Min uint: {uint.MinValue}");
            Console.WriteLine($"Max int: {uint.MaxValue}");
            
            Console.WriteLine($"Min long: {long.MinValue}");
            Console.WriteLine($"Max long: {long.MaxValue}");
            Console.WriteLine($"Min ushort: {ulong.MinValue}");
            Console.WriteLine($"Max ushort: {ulong.MaxValue}");
        }

        private enum Weekdays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6,
        }

        private enum GameState
        {
            PLAY = 0,
            HELP = 1,
            EXIT = 2,
        }
        
        private static void Main(string[] args)
        {
            Random random = new Random();
            Array values = typeof(GameState).GetEnumValues();
            
            GameState state = (GameState)values.GetValue(random.Next(values.Length));

            switch (state)
            {
                case GameState.PLAY:
                    Console.WriteLine("playing");
                    break;
                case GameState.HELP:
                    Console.WriteLine("help menu");
                    break;
                case GameState.EXIT:
                    Console.WriteLine("exiting");
                    break;
                default:
                    Console.WriteLine("unknown state");
                    break;
            }

        }
    }
}