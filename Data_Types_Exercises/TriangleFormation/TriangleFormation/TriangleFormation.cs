﻿using System;

namespace TriangleFormation
{
    class TriangleFormation
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && c + b > a)
            {
                Console.WriteLine("Triangle is valid.");
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }

                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
            
            
        }
    }
}
