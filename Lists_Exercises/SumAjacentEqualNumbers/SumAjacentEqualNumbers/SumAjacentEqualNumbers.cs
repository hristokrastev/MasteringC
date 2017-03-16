using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAjacentEqualNumbers
{
    class SumAjacentEqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            var result = new List<double>();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                while (i < numbers.Count - 1)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        if (i > 0)
                        {
                            i--;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
