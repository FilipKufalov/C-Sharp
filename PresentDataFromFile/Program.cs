using System;

namespace PresentDataFromFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: " + fileName + " file.txt");
            } else
            {
                string[] lines = System.IO.File.ReadAllLines(@System.AppContext.BaseDirectory + args[0]);
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }
            }
        }
    }
}
