// See https://aka.ms/new-console-template for more information
using System;
namespace FlipCoin
{
    class Program
    {
        public static void Main(String[] args)

        {
            Console.WriteLine("flip coin");
            Console.WriteLine("enter number of flips");
            double NoOfFlips = Convert.ToDouble(Console.ReadLine());
            if (NoOfFlips > 0)
            {
                FlippingCoin(NoOfFlips);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
           
        }

        public static void FlippingCoin(double NoOfFlips)
        {
            double headCount = 0;
            double tailCount = 0;
            for (int i = 0; i < NoOfFlips; i++)
            {
                Random random = new Random();
                double flip = Convert.ToDouble(random.Next(1, 100)) / 100;
                headCount = flip > 0.5 ? headCount + 1 : headCount;
                tailCount = flip < 0.5 ? tailCount + 1 : tailCount;
            }

            double headPercent = (headCount / NoOfFlips) * 100;
            double tailPercent = (tailCount / NoOfFlips) * 100;
            Console.WriteLine($"Heads:{headPercent}% Tails:{tailPercent}%");
        }
    }
}