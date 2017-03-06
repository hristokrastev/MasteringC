using System;

namespace RepeatString
{
    class RepeatString
    {
        static void Main()
        {
            var str = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());
            Console.WriteLine(repeatString(str, count));
        }
        static string repeatString(string str, int count)
        {
            string reapeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                 reapeatedString += str;
            }
            return reapeatedString;
        }
    }
}
