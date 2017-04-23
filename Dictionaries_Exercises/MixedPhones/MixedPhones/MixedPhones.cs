using System;
using System.Collections.Generic;
namespace MixedPhones
{
    public class MixedPhones
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var sortedResult = new SortedDictionary<string, long>();

            
            while (line != "Over")
            {
                var parts = line.Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var firstElement = parts[0];
                var secondElement = parts[1];
                var number = 0L;
                if (long.TryParse(firstElement, out number))
                {
                    sortedResult[secondElement] = number;
                }
                else if(long.TryParse(secondElement, out number))
                {
                    sortedResult[firstElement] = number;
                }
               
                line = Console.ReadLine();
            }
            foreach (var kvp in sortedResult)
            {
                var keys = kvp.Key;
                var values = kvp.Value;

                Console.WriteLine($"{keys} -> {values}");
            }
        }
    }
}
