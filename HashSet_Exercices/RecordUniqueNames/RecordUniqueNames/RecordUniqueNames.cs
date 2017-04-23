using System;
using System.Collections.Generic;
namespace RecordUniqueNames
{
    public class RecordUniqueNames
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var name = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var inputNames = Console.ReadLine();
                name.Add(inputNames);
            }
            Console.WriteLine(string.Join(Environment.NewLine, name));
        }
    }
}
