using System;
using System.Linq;

namespace LargestArrayElements
{
    class LargestArrayElements
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            var biggestNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                var currentNumber = numbers[i];
                if (currentNumber > biggestNumber)
                {
                    biggestNumber = currentNumber;
                }
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
