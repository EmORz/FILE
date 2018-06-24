using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../text.txt");
            string[] output = new string[input.Length];
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = $"{count}. {input[i]}";
                count++;
            }
            File.WriteAllLines("../../../output.txt", output);
        }
    }
}
