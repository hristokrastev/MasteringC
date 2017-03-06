using System;

namespace IntTobase
{
    class IntToBase
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(number, toBase));
        }
        static string IntegerToBase(int number, int toBase)
        {
            string foundedNumber = string.Empty;
            while (number > 0)
            {
                var reminder = number % toBase;
                foundedNumber = reminder + foundedNumber;
                number /= toBase;
            }          
            return foundedNumber;
         }

    }
}
