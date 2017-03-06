using System;
using System.Linq;

namespace CountOfOddNumbersInArray
{
    class CountOfOddNumbersInArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var oddElements = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                if(Math.Abs(currentNumber) % 2 == 1)
                {
                    oddElements++;
                }
            }
            Console.WriteLine(oddElements);
        }
    }
}
