using System;

namespace TrickyStrings
{
    class TrickyStrings
    {
        static void Main()
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());

            var result = string.Empty;
            var currentString = string.Empty;
            for (int i = 0; i < numberOfStrings - 1; i++)
            {
                currentString += Console.ReadLine() + delimiter;

            }
            currentString = currentString + Console.ReadLine();
            result += currentString;
            Console.WriteLine(result);
        }
    }
}
