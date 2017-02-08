using System;

namespace DigitWithWords
{
    class DigitWithWords
    {
        static void Main(string[] args)
        {
            string wordForConvert = Console.ReadLine().ToLower();

            string newWord = wordForConvert;
 
            switch (wordForConvert)
            {
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eighth":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "zero":
                    Console.WriteLine("0");
                    break;
                default:
                    Console.WriteLine("not a number");
                    break;
            }
        }
    }
}
