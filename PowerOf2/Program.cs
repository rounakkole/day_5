// See https://aka.ms/new-console-template for more information
using System;
namespace PowerOf2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("table of the powers of 2 that are less than or equal to 2^N");
            int Number = Convert.ToInt32(Console.ReadLine());
            PowerTable(Number);

        }

        public static void PowerTable(int Number)
        {
            int Answer = 1;
            int i = 1;
            while (i <= Number && i < 31)
            {
                Answer *= 2;
                Console.WriteLine($"2^{i} = {Answer}");
                i++;
            }
        }
    }
}
