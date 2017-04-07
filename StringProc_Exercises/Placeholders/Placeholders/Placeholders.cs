using System;
using System.Text;
namespace Placeholders
{
    class Placeholders
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            while (!(text == "end"))
            {
                var whereToReplace = text.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var elements = whereToReplace[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder builder = new StringBuilder(whereToReplace[0]);

                for (int i = 0; i < elements.Length; i++)
                {
                    var currentPlaceholders = "{" + i + "}";
                    builder.Replace(currentPlaceholders, elements[i]);
                    builder.ToString();
                }
                Console.WriteLine(builder);
                text = Console.ReadLine();
            }
        }
    }
}
