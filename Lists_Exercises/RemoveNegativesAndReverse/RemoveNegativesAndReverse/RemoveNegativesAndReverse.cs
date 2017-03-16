using System;
using System.Linq;
using System.Collections.Generic;
namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();
            for (int i = numbers.Count - 1; i >= 0 ; i--)
            {
                if (numbers[i] >= 0)
                {
                    result.Add(numbers[i]);
                }
            }
            
            if (numbers[0] >= 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
