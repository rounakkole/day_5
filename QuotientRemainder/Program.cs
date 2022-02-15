// See https://aka.ms/new-console-template for more information

using System;

namespace QuotientRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compute Quotient and Remainder");
            Console.WriteLine("enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number + " divided by:");
            int divider = Convert.ToInt32(Console.ReadLine());

            int quotient = number / divider;
            double remainder = (double)number % divider;
            Console.WriteLine($"quotient:{quotient} remainder:{remainder}");
        }
    }
}
