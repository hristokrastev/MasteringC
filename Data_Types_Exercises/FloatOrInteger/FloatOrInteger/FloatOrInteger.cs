using System;

namespace FloatOrInteger
{
    class FloatOrInteger
    {
        static void Main()
        {
            var number = Console.ReadLine();

            Console.WriteLine((int)Math.Round(double.Parse(number)));
        }
    }
}
