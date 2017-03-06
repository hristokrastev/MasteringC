using System;
using System.Linq;

namespace CountOccurranceOfLargerElement
{
    class CountOccurranceOfLargerElement
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var element = double.Parse(Console.ReadLine());
            var largerElements = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                if (currentNumber > element)
                {
                    largerElements++;
                }
            }
            Console.WriteLine(largerElements);
        }
    }
}
