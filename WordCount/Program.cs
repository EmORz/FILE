using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("../../../words.txt").ToLower().Split();
            string[] input = File.ReadAllText("../../../input.txt").ToLower()
                .Split(new char[] { ' ', '.', '-', ',', '?', '!', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> matchAndCount = new Dictionary<string, int>();
            List<string> str = new List<string>();
            foreach (var word in words)
            {
                matchAndCount.Add(word, 0);
            }
            foreach (var word in input)
            {
                if (matchAndCount.ContainsKey(word))
                {
                    matchAndCount[word]++;
                }
            }
            foreach (var item in matchAndCount.OrderByDescending(x => x.Value))
            {
                string temp = item.Key + " - " + item.Value;
                str.Add(temp);
            }
            File.WriteAllLines("../../../output.txt", str);

        }
    }
}
