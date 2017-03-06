using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseString
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            if (Int32.TryParse("-105", out j))
                Console.WriteLine(j);
            else
                Console.WriteLine("String could not be parsed.");
        }
    }
}
