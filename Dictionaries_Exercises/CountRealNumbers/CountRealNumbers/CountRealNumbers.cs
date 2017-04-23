using System;
using System.Collections.Generic;
using System.Linq;
namespace CountRealNumbers
{
    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            var sortedResult = new SortedDictionary<double, int>();
            foreach (var number in inputLine)
            {
                if (!sortedResult.ContainsKey(number))
                {
                    sortedResult[number] = 0;
                }
                sortedResult[number]++;
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
