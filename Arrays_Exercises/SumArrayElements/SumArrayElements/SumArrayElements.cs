using System;

namespace SumArrayElements
{
    class SumArrayElements
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];
            var result = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                numbers[i] = currentNumber;
                result += numbers[i];
            }
            Console.WriteLine(result);
        }
    }
}
