using System;

namespace PrintTriangle
{
    class PrintTriangle
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            printTriangle(num);
        }
        static void printTriangle(int num)
        {
            for (int j = 1; j <= num; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            for (int bot = num - 1; bot >= 1; bot--)
            {
                for (int i = 1; i <= bot; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();               
            }
        }       
    }
}
