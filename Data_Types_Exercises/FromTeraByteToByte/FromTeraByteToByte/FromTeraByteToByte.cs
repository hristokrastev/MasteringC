using System;

namespace FromTeraByteToByte
{
    class FromTeraByteToByte
    {
        static void Main()
        {
            var terabyte = Console.ReadLine();

            double newTerabyte = double.Parse(terabyte);

            double terabyteToBits = newTerabyte * 8796093022208;

            Console.WriteLine(terabyteToBits);

        }
    }
}
