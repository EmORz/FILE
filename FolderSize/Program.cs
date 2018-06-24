using System;
using System.IO;
using System.Linq;



namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Directory.GetFiles(@"C:\Users\user\source\repos\Excercises\FolderSize\bin\Debug\TestFolder");
            double sum = 0.0;

            for (int i = 0; i < arr.Length; i++)
            {
                FileInfo info = new FileInfo(arr[i]);
                sum += info.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("../../../sizeOfFiles.txt", sum.ToString());
        }
    }
}
