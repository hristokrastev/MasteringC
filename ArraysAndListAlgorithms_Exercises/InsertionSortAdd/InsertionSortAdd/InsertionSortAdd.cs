using System;
using System.Collections.Generic;
using System.Linq;
namespace InsertionSortAdd
{
    class InsertionSortAdd
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
