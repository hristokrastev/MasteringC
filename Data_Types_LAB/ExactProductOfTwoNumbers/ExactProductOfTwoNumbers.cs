using System;


namespace ExactProductOfTwoNumbers
{
    class ExactProductOfTwoNumbers
    {
        static void Main()
        {
            int numbersOfProducts = int.Parse(Console.ReadLine());
            decimal result = 1M;
            for (int i = 1; i <= numbersOfProducts; i++)
            {
                result *= decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);

        }
    }
}
