﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace TrackDownloader
{
    class TrackDownloader
    {
        static void Main()
        {
            string[] blacklisted = Console.ReadLine().Split();
            List<string> filenames = ReadFilenames();
            filenames = filenames
                       .Where(a => ContainsBlackListed(a, blacklisted))
                       .OrderBy(a => a)
                       .ToList();
            Console.WriteLine(string.Join("\r\n", filenames));
        }
        
        private static bool ContainsBlackListed(string a, string[] blacklisted)
        {
            for (int i = 0; i < blacklisted.Length; i++)
            {
                if (a.Contains(blacklisted[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static List<string> ReadFilenames()
        {
            List<string> output = new List<string>();
            string filename = Console.ReadLine();
            while (filename != "end")
            {
                output.Add(filename);
                filename = Console.ReadLine();
            }
            return output;
        }
    }
}