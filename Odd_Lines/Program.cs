using System;
using System.Collections.Generic;
using System.IO;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../files.txt");
            List<string> odds = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 !=0)
                {
                    odds.Add(input[i]);
                }
            }
            File.WriteAllLines("../../../Odd.txt", odds);
        }
    }
}
