using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int allNumbers = int.Parse(Console.ReadLine());

            
            for (int num= 0; num <= allNumbers; num++)
            {
                int sumOfDigits = 0;
                int digit = num;
               
                
                while (digit > 0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                }
                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{num} -> {special}");
            }
            
        }
    }
}
