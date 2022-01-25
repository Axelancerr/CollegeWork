using System;

namespace Lesson08
{
    class Program
    {
        private static void PrintInventory(int[] inv)
        {
            var message = "";
            foreach (var item in inv)
            {
                message += $"{Convert.ToString(item)}, ";
            }
            Console.WriteLine(message);
        }

        private static void SortInventory(int[] inv) 
        {  
            bool swapped;
            int temp;

            for (var loopNumber = 0; loopNumber < inv.Length - 1; loopNumber++)
            {
                swapped = false;
                for (var index = 0; index < inv.Length - loopNumber - 1; index++)
                {
                    if (inv[index] > inv[index + 1])
                    {
                        temp = inv[index];
                        inv[index] = inv[index + 1];
                        inv[index + 1] = temp;
                        swapped = true;
                    }
                    if (swapped == false)
                    {
                        break;
                    }
                } 
            }
        }
        
        private static void Main(string[] args) {
            
            int[] inventory = new int[100];
            Random random = new Random();
            for (var i = 0; i < 100; i++) 
            {
                inventory[i] = random.Next(1, 100);
            }
        
            SortInventory(inventory);
            PrintInventory(inventory);
        }
    }
}