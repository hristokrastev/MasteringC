using System;
using System.Collections.Generic;
using System.Linq;
namespace TearListInHalf
{
    class TearListInHalf
    {
        static void Main()
        {
            var numbersToBeSeparated = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var firstNumbers = new List<int>();
            var secondNumbers = new List<int>();
            var result = new List<int>();
            for (int i = 0; i < numbersToBeSeparated.Count; i++)
            {

                if(i >= numbersToBeSeparated.Count / 2)
                {
                    secondNumbers.Add(numbersToBeSeparated[i]);
                }else
                {
                    firstNumbers.Add(numbersToBeSeparated[i]);
                }
            }
            for (int i = 0; i < numbersToBeSeparated.Count / 2; i++)
            {
                result.Add(secondNumbers[i] / 10);
                result.Add(firstNumbers[i]);
                result.Add(secondNumbers[i] % 10);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
