// See https://aka.ms/new-console-template for more information
using System;

namespace LargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the largest among three numbers");
            Console.WriteLine("enter 3 numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest = num1 > num2 ? num1 : num2;
            largest = largest > num3 ? largest : num3;
            Console.WriteLine($"largest: {largest}");
        }
    }
}
