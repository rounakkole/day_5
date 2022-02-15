// See https://aka.ms/new-console-template for more information
using System;
namespace factorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("prime factorization");
            Console.WriteLine("enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int newNumber = number;
            for (int i = 2; i < (number/2)+1; i++)
            {
                int remainder = newNumber % i;
                if (remainder == 0)
                {
                    newNumber = newNumber / i;
                    Console.WriteLine(i);
                    i = 1;
                }
            }
        }
    }
}
