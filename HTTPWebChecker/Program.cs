using System;
using System.IO;
using System.Threading.Tasks;

namespace HTTPWebChecker
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string fileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: " + fileName + " file.txt");
            }
            else
            {
                string[] lines = System.IO.File.ReadAllLines(@System.AppContext.BaseDirectory + args[0]);
                foreach (string line in lines)
                {
                    using var client = new System.Net.Http.HttpClient();
                    try
                    {
                        var result = await client.GetAsync("https://" + line);
                        if (result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            Console.WriteLine(line + " is UP!");
                            using StreamWriter file = new("alive.txt", append: true);
                            await file.WriteLineAsync(line);
                        }
                        else
                        {
                            Console.WriteLine(line + " Unknown Status!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(line + " is DOWN!");
                    }
                    finally
                    {

                    }
                }
            }
        }
    }
}
