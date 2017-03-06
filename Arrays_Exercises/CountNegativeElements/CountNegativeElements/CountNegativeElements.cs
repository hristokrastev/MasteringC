using System;
using System.Linq;

namespace CountNegativeElements
{
    class CountNegativeElements
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new int[n];
            var negativeElements = 0;
            for (int i = 0; i < n; i++)
            {
                
                numbers[i] = int.Parse(Console.ReadLine());
                var currentNumber = numbers[i];
                if (currentNumber < 0)
                {
                    negativeElements++;
                }
            }
            Console.WriteLine(negativeElements);
        }
    }
}
