using System;
using System.Collections.Generic;
using System.Linq;
namespace ArrayContainsElement
{
    class ArrayContainsElement
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var element = int.Parse(Console.ReadLine());

            bool isContain = numbers.Contains(element);

            if (isContain)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
