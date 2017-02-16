using System;

namespace DrawFilledSquare
{
    class DrawFilledSquare
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            filledSqaure(num);
        }
        static void filledSqaure(int num)
        {
            for (int topAndBot = 1; topAndBot <= num; topAndBot++)
            {
                Console.Write("--");
            }
            Console.WriteLine();

            for (int j = 1; j <= num - 2; j++)
            {
                Console.Write("-");
                for (int i = 1; i < num; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
            

            for (int topAndBot = 1; topAndBot <= num; topAndBot++)
            {
                Console.Write("--");
            }
            Console.WriteLine();
        }
    }
}
