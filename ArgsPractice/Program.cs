using System;

namespace ArgsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }


        }
    }
}
