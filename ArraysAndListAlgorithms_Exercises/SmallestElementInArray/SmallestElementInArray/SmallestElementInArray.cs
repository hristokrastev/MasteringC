using System;
using System.Collections.Generic;
using System.Linq;
namespace SmallestElementInArray
{
    class SmallestElementInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var smallestElement = numbers.Min();

            Console.WriteLine(smallestElement);
        }
    }
}
