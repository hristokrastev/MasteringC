using System;
using System.Globalization;

namespace TravelingWithLightSpeed
{
    class TravelingWithLightSpeed
    {
        static void Main()
        {
            var input = Console.ReadLine();

            decimal lightYearToConvert = decimal.Parse(input);

            decimal lightYear = 9450000000000M;
            decimal speedOfLight = 300000M;

            decimal totalTimeInSeconds = lightYearToConvert * (lightYear / speedOfLight);

            TimeSpan diff = TimeSpan.FromSeconds((double)totalTimeInSeconds);
            string formatted = string.Format(
                              CultureInfo.CurrentCulture,
                              "{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds\n",
                              diff.Days / 7,
                              diff.Days % 7,
                              diff.Hours,
                              diff.Minutes,
                              diff.Seconds);

            Console.WriteLine(formatted);
        }
    }
}
