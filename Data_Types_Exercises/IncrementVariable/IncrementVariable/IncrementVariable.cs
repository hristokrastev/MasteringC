using System;

namespace IncrementVariable
{
    class IncrementVariable
    {
        static void Main()
        {
            int value = int.Parse(Console.ReadLine());

            int remaining = value % 256;

            int overFlows = value / 256;

            Console.WriteLine($"{remaining}");
            Console.WriteLine($"Overflowed {overFlows} times");
        }
    }
}
