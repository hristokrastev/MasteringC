using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cards
{
    public class Cards
    {
        public static void Main()
        {
            var pattern = @"([1]?[2-9JQKA10])([SHDC])";
            var allCards = Console.ReadLine();
            var regex = new Regex(pattern);
            var validCards = new List<string>();

            MatchCollection matchedCards = regex.Matches(allCards);

            foreach (Match cards in matchedCards)
            {
                int power = 0;
                if (int.TryParse(cards.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                validCards.Add(cards.Value);
            }
            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}
