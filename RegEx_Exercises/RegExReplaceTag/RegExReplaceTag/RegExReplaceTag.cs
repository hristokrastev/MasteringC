using System;
using System.Text.RegularExpressions;

namespace RegExReplaceTag
{
    public class RegExReplaceTag
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var result = string.Empty;
           
            while (text != "end")
            {
                
                var pattern = @"<a.+?href=(.+?)>(.+?)<\/.>";
                var regex = new Regex(pattern);
                var replacement = "[URL href=$1]$2[/URL]";

                text = regex.Replace(text, replacement);
                Console.WriteLine(text);
                text = Console.ReadLine();
            }
            
        }
    }
}
