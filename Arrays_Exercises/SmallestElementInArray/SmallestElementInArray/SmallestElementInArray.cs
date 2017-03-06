using System;
using System.Linq;


namespace SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var smallestNumber = int.MaxValue;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber < smallestNumber)
                {
                     smallestNumber = currentNumber;
                }

            }
            Console.WriteLine(smallestNumber);
        }
    }
}
