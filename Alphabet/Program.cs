// See https://aka.ms/new-console-template for more information
using System;

namespace Alphabet
{
    internal class Program
    {
        public static string result = "consonant";
        static void Main(string[] args)
        {
            Console.WriteLine("Check Whether an Alphabet is Vowel or Consonant");
            char alphabet = Convert.ToChar(Console.ReadLine());
            char[] vowel = new char[10] { 'a', 'e', 'i', 'o', 'u','A','E','I','O','U'};
            foreach (char character in vowel)
            {
                if (character == alphabet)
                {
                    result = "vowel";
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
