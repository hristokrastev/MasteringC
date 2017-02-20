using System;

namespace MathPower
{
    class MathPower
    {
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
           
            Console.WriteLine(poweredNumber(number, power));
        }
        static double poweredNumber(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
