using System;

namespace NthDigit
{
    class NthDigit
    {
        static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));
        }
        static int FindNthDigit(long number, int index)
        {
            long newNumber = 0;
            while (index > 0)
            {
                newNumber = number % 10;
                number = number / 10;
                index--;
            }
            return (int)newNumber;
        }
    }
}
