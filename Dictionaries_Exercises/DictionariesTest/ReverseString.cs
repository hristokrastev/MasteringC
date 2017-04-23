using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
	class ReverseString
	{
		public static void Main()
		{
            var text = Console.ReadLine().ToArray();

            var result = text.Reverse();

            Console.WriteLine(string.Join("", result));
		}
	}
}
