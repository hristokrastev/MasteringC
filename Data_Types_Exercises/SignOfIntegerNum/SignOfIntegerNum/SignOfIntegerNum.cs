using System;

namespace SignOfIntegerNum
{
    class SignOfIntegerNum
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            SignOfNum(num);


        }
        static void SignOfNum(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
