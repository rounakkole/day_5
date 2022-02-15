// See https://aka.ms/new-console-template for more information
using System;
namespace EvenOdd
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Check whether a Number is Even or Odd");
            Console.WriteLine("enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int check = number % 2;
            string result = check == 0 ? "even" : "odd";
            Console.WriteLine($"{number} is a {result} number");
        }
    }
}