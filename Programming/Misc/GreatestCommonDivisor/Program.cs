using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        private static double FindHighestCommonDenominator(double num1, double num2) {
            
            double result = num1 / num2;
            if (result % 1 == 0) {
                return num2;
            }
            
            double remainder = num1 % num2;
            return FindHighestCommonDenominator(num2, remainder);
        }
        
        private static void Main(string[] args) {
            Console.WriteLine("Input the 1st number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the 2nd number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Greatest common divisor is: {FindHighestCommonDenominator(num1, num2)}");
        }
        
    }
}