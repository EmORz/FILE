using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = File.ReadAllLines("../../../first.txt").Select(int.Parse).ToArray();
            int[] second = File.ReadAllLines("../../../second.txt").Select(int.Parse).ToArray();
            List<int> third = new List<int>();
            third.AddRange(first);
            third.AddRange(second);
            int[] tr = third.OrderBy(x => x).ToArray();
            List<string> newArrayStr = new List<string>();
            foreach (var item in tr)
            {
                string temp = item.ToString();
                newArrayStr.Add(temp);
            }
            File.WriteAllLines("../../../result.txt", newArrayStr);
        }
    }
}
