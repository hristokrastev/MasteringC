using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeString
{
    class SerializeString
    {
        static void Main()
        {
            var allChars = Console.ReadLine();
            var result = string.Empty;

            for (int i = 0; i < allChars.Length; i++)
            {
                
                var indexOfResult = new List<int>();
                var currentChar = allChars[i];
                var index = -1;
                if (!result.Contains(currentChar))
                {
                    result += currentChar;
                    result += ":";
                    while (true)
                    {
                        index = allChars.IndexOf(currentChar, index + 1);
                        if (index < 0)
                        {
                            break;
                        }
                        indexOfResult.Add(index);
                    }
                    result += (string.Join("/", indexOfResult));
                    result += "\r\n";
                }
                continue;
            }
            Console.WriteLine(result.TrimEnd());
            
        }
    }
}
