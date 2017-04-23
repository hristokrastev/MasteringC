using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FishStatistics
{
    public class FishStatistics
    {
        public static void Main()
        {
            var pattern = @"([>]*)<([\(]*)([\'\-x])[>]";
            var text = Console.ReadLine();
            var regex = new Regex(pattern);

            var tailLength = new List<int>();
            var bodyLength = new List<int>();
            var status = new List<string>();
            var fishIndex = new List<string>();

            var isMatch = regex.IsMatch(text);
            MatchCollection matchedFish = regex.Matches(text);
            if (!isMatch)
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
                var notValidFish = 0;
                foreach (Match fish in matchedFish)
                {
                    
                    if (fish.Groups[2].Length < 1)
                    {
                        notValidFish++;
                        continue;
                    }
                    fishIndex.Add(fish.Value);
                    tailLength.Add(fish.Groups[1].Length * 2);
                    bodyLength.Add(fish.Groups[2].Length * 2);
                }

                for (int i = 0; i < matchedFish.Count - notValidFish; i++)
                {
                    if (bodyLength[i] < 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Fish {i + 1}: {fishIndex[i]}");
                        if (tailLength[i] > 10)
                        {
                            Console.WriteLine($"Tail type: Long ({tailLength[i]} cm)");
                        }
                        else if (tailLength[i] > 2)
                        {
                            Console.WriteLine($"Tail type: Medium ({tailLength[i]} cm)");
                        }
                        else if (tailLength[i] == 2)
                        {
                            Console.WriteLine($"Tail type: Short ({tailLength[i]} cm)");
                        }
                        else
                        {
                            Console.WriteLine($"Tail type: None");
                        }

                        if (bodyLength[i] > 20)
                        {
                            Console.WriteLine($"Body type: Long ({bodyLength[i]} cm)");
                        }
                        else if (bodyLength[i] > 10)
                        {
                            Console.WriteLine($"Body type: Medium ({bodyLength[i]} cm)");
                        }
                        else if (bodyLength[i] > 1)
                        {
                            Console.WriteLine($"Body type: Short ({bodyLength[i]} cm)");
                        }


                        if (matchedFish[i].Groups[3].Value == "'")
                        {
                            status.Add("Awake");
                        }
                        else if (matchedFish[i].Groups[3].Value == "-")
                        {
                            status.Add("Asleep");
                        }
                        else
                        {
                            status.Add("Dead");
                        }
                        Console.WriteLine($"Status: {status[i]}");
                    }

                }
            }
        }
    }
}
