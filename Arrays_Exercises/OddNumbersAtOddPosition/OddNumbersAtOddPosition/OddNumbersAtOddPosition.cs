using System;
using System.Linq;

namespace OddNumbersAtOddPosition
{
    class OddNumbersAtOddPosition
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 1)
                {
                    
                    if (Math.Abs(numbers[i]) % 2 == 1)
                    {
                        Console.Write($"Index {i} -> ");
                        Console.WriteLine(numbers[i]);
                    }
                }
            }
         }
    }
}
