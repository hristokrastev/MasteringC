using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { '.', '!', ',', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new List<string>();
            foreach (var words in text)
            {
                if (words.SequenceEqual(words.Reverse()))
                {
                    result.Add(words);
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
