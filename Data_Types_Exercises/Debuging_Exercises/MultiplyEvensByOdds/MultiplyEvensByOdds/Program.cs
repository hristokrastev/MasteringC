using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultiplyOfEvensByOdds(n));
        }
        static long GetMultiplyOfEvensByOdds(int n)
        {
            long sumEven = GetSumOfEvenNumbers(n);
            long sumOdd = GetSumOfOddNumbers(n);
            return sumEven * sumOdd;
        }

        private static long GetSumOfOddNumbers(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static long GetSumOfEvenNumbers(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
