// See https://aka.ms/new-console-template for more information
using System;
namespace getFactorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("harmonic number");
            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Harmonic(number);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }

        public static void Harmonic(int number)
        {
            double answer = 0;
            double division;
            for (int i = 1; i <= number; i++)
            {
                division = (double)1 / i;
                answer = answer + division;
                Console.WriteLine($"1/{i}");
            }
            Console.WriteLine(answer);
        }
    }
}
