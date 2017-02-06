using System;

namespace DistanceOfTheStar
{
    class DistanceOfTheStar
    {
        static void Main()
        {
            decimal lightYear = 9450000000000M;

            decimal earthToNearestStar = 4.22M * lightYear;
            decimal distanceToMilkyWay = 26000M * lightYear;
            decimal diameterOfMilkyWay = 100000M * lightYear;
            decimal distanceFromEarthToOtherUniverse = 46500000000M * lightYear;

            Console.WriteLine(earthToNearestStar.ToString("e2"));
            Console.WriteLine(distanceToMilkyWay.ToString("e2"));
            Console.WriteLine(diameterOfMilkyWay.ToString("e2"));
            Console.WriteLine(distanceFromEarthToOtherUniverse.ToString("e2"));

        }
    }
}
