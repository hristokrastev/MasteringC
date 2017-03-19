using System;
using System.Collections.Generic;
using System.Linq;
namespace SortArrayUsingBubbleSort
{
    class SortArrayUsingBubbleSort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int temp = 0;

            for (int write = 0; write < numbers.Count; write++)
            {
                for (int sort = 0; sort < numbers.Count - 1; sort++)
                {
                    if (numbers[sort] > numbers[sort + 1])
                    {
                        temp = numbers[sort + 1];
                        numbers[sort + 1] = numbers[sort];
                        numbers[sort] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
