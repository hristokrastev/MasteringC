using System;

namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            string hexDecimal = Console.ReadLine();

            string decim = Convert.ToInt32(hexDecimal, 10).ToString();

            Console.WriteLine(decim);
        }
    }
}
