using System;
using System.Linq;

namespace MultiplyAnArray
{
    class MultiplyAnArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var multiply = double.Parse(Console.ReadLine());
            var result = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
               result[i] = numbers[i] * multiply;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
