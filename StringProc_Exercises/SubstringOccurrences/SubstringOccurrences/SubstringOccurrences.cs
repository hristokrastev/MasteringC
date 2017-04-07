using System;
namespace SubstringOccurrences
{
    class SubstringOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var count = 0;
            var index = -1;

            while (true)
            {
                index = text.IndexOf(pattern, index + 1);
                if (index < 0)
                {
                    break;
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
