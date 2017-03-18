using System;
using System.Collections.Generic;
using System.Linq;
namespace EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var numbers1 = Console.ReadLine()
                .Split()
                .ToList();
            var numbersWhereToRemove = Console.ReadLine()
                .Split()
                .ToList();
            var firstNumbers = 0;
            var secondNumbers = 0;

            foreach (var item in numbers1)
            {
                if (numbersWhereToRemove.Contains(item))
                {
                    numbersWhereToRemove.Remove(item);
                }
                firstNumbers += int.Parse(item);
            }
            foreach (var item in numbersWhereToRemove)
            {
                secondNumbers += int.Parse(item);
            }
            if (firstNumbers == secondNumbers)
            {
                Console.WriteLine($"Yes. Sum: {firstNumbers}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstNumbers - secondNumbers)}");
            }
        }
    }
}
