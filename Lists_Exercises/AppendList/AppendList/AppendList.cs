using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendList
{
    class AppendList
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split('|')
                .ToList();

            input.Reverse();
            var result = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                var currentString = input[i].Split(' ').ToList();
                for (int j = 0; j < currentString.Count; j++)
                {
                    if (currentString[j] != " " && currentString[j] != "")
                    {
                        result.Add(currentString[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
