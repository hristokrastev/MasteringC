using System;
using System.Collections.Generic;
using System.Linq;
namespace CountNumbers
{
    class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            numbers.Sort();
            numbers.Add(int.MaxValue);
            var count = 1;
            var result = new List<int>();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    result.Add(numbers[i]);
                    result.Add(count);
                    count = 1;
                }
            }
            Console.WriteLine(string.Join(" -> ",result));
        }
    }
}
