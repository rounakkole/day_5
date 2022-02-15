// See https://aka.ms/new-console-template for more information
using System;

namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("swap two numbers");
            Console.WriteLine("enter first number:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter first number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            num1=num1 + num2;
            num2 = num1 - num2;
            num1=num1 - num2;
            Console.WriteLine($"first:{num1}  second:{num2}");
        }
    }
}
