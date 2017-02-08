using System;

namespace TrickyStrings
{
    class TrickyStrings
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            
            string withDelimiter = "";

            for (int i = 0; i < number - 1; i++)
            {
                string input = Console.ReadLine();
                withDelimiter += input.ToString();
                withDelimiter += delimiter.ToString();

            }
            string withoutDelimiter = Console.ReadLine();
            Console.WriteLine(withDelimiter + withoutDelimiter);
        }
    }
}
