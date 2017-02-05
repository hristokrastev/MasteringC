using System;

namespace RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
              
            for (int num = 1; num <= number; num++)
            {
                int sumOfDigit = 0;
                int digit = num;
                while (digit > 0)
                {
                    sumOfDigit += digit % 10;
                    digit = digit / 10;
                }
                bool special = false;
                special = (sumOfDigit == 5) || (sumOfDigit == 7) || (sumOfDigit == 11);
                Console.WriteLine($"{num} -> {special}");
                
             
            }

        }
    }
}
