using System;

namespace GetMin
{
    class GetMin
    {
        static void Main()
        {
            var inp1 = int.Parse(Console.ReadLine());
            var inp2 = int.Parse(Console.ReadLine());
            var inp3 = int.Parse(Console.ReadLine());
           Console.WriteLine(getMin(inp1, inp2, inp3));
        }
        static int getMin(int inp1, int inp2, int inp3)
        {
            var min = Math.Min(inp1, inp2);
            var minEnd = Math.Min(inp3, min);
            return minEnd;
        }
    }
}
