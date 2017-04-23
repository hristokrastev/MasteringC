using System;
using System.Collections.Generic;
namespace ReferencedDictionary
{
    public class ReferencedDictionary
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, int>();

            while (input != "end")
            {
                
                var elements = input.Split();
                var firstElement = elements[0];
                var lastElement = elements[elements.Length - 1];
                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    result[firstElement] = number;
                }
                else
                {
                    if (result.ContainsKey(lastElement))
                    {
                        var referenced = result[lastElement];
                        result[firstElement] = referenced;
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
