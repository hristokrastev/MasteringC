using System;
namespace SentenceSplit
{
    class SentenceSplit
    {
        static void Main()
        {
            var sentence = Console.ReadLine();

            var delimiter = Console.ReadLine();
            
            var partsOfText = sentence.Replace(delimiter, "10");

            var parts = partsOfText.Split(new string[] { "10" }, StringSplitOptions.None);

            Console.WriteLine("[" + string.Join(", ", parts) + "]");
        }
    }
}
