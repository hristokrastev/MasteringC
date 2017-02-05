using System;

namespace DataTypesAndVar
{
    class ConvertorForYears
    {
        static void Main()
        {
            int years = int.Parse(Console.ReadLine());

            int days = years * 365;
            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes.");

        }
    }
}