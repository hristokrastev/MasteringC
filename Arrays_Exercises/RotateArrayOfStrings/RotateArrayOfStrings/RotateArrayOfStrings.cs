using System;
using System.Linq;


namespace RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main()
        {
            var text = Console.ReadLine()
                .Split(' ');
            var rotated = new string[text.Length];
            var last = text[text.Length - 1];

            for (int i = 0; i < text.Length - 1; i++)
            {
                rotated[i + 1] = text[i];
            }
            rotated[0] = last;

            Console.WriteLine(string.Join(" ", rotated));

        }
    }
}
