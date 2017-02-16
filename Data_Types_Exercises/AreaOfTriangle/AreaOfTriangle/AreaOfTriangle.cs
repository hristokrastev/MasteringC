using System;

namespace AreaOfTriangle
{
    class AreaOfTriangle
    {
        static void Main()
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());

            Console.WriteLine(areaOfTriangle(sideA, sideB));

        }
        static double areaOfTriangle(double firstSide, double secondSide)
        {
            double area = ((double)firstSide * (double)secondSide) / 2;
            return area;
        }
    }
}
