using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().ToLower().Split().ToList();

            var resultDictionary = new Dictionary<string, int>();

            foreach (var words in inputLine)
            {
                if (!resultDictionary.ContainsKey(words))
                {
                    resultDictionary[words] = 0;
                }
                resultDictionary[words]++;
            }
            var result = new List<string>();
            foreach (var kvp in resultDictionary)
            {
                if (kvp.Value % 2 == 1)
                {
                    result.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
