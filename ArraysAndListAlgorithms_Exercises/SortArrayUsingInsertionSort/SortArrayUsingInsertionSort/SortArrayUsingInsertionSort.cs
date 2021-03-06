﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace SortArrayUsingInsertionSort
{
    class SortArrayUsingInsertionSort
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    var current = numbers[i];
                    var next = numbers[i + 1];
                    if (current > next)
                    {
                        numbers[i + 1] = current;
                        numbers[i] = next;
                        swapped = true;
                    }
                }
            } while (swapped);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
