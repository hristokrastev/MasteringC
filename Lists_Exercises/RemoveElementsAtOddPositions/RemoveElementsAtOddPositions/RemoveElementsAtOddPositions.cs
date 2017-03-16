using System;
using System.Collections.Generic;
using System.Linq;
namespace RemoveElementsAtOddPositions
{
    class RemoveElementsAtOddPositions
    {
        static void Main()
        {
            var text = Console.ReadLine()
                .Split(' ')
                .ToList();
            var result = new List<string>();
            for (int i = 0; i < text.Count; i++)
            {
                if (i % 2 == 1)
                {
                    result.Add(text[i]);
                }
            }
            Console.WriteLine(string.Join("",result));
        }
    }
}
