using System;
using System.Collections.Generic;
using System.Linq;
namespace LargestNElements
{
    class LargestNElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var numberOfElements = int.Parse(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();
            var result = new List<int>();
            for (int i = 0; i < numberOfElements; i++)
            {
                result.Add(numbers[i]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
