using System;
using System.Collections.Generic;
using System.Linq;
namespace FlipListSides
{
    class FlipListSides
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 1; i <= (numbers.Count - 2) / 2; i++)
            {
                    Swap(numbers, i, numbers.Count - (i + 1));
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        public static void Swap(IList<int> list, int indexA, int indexB)
        {
            int tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}
