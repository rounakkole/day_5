// See https://aka.ms/new-console-template for more information
using System;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("check leap year");
            Console.WriteLine("enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 999 && year < 10000)
            {
                printLeap(checkLeap(year), year);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }

        public static void printLeap(bool isLeap,int year)
        {
            if (isLeap == true)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else if (isLeap == false)
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }

        public static bool checkLeap(int year)
        {
            bool isLeap;
            int four = year % 4;
            int hundred = year % 100;
            int fourHundred = year % 400;
            if (hundred == 0)
            {
                if (fourHundred == 0)
                {
                    isLeap = true;
                }
                else
                {
                    isLeap = false;
                }
            }
            else if (four == 0)
            {
                isLeap = true;
            }
            else
            {
                isLeap = false;
            }
            return isLeap;
        }
    }
}
