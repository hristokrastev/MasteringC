using System;
using System.Linq;

namespace CountOfGivenElementInArray
{
    class CountOfGivenElementInArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var element = int.Parse(Console.ReadLine());

            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber == element)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
