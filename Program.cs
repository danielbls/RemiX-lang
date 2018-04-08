using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOLD;

namespace Remix
{
    class Program
    {
        static void Main(string[] args)
        {
            string dashes = "---------------------------------------------";

            // Console BS
            Console.Clear();
            Console.Title = $"Remix 0.1a";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BufferHeight = Console.WindowHeight;
            Console.WriteLine($"{dashes}\r\n Remix 0.1a   [{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}]\r\n{dashes}\r\n");

            // Parser Setup

            string file = args.Length > 0 ? args[0] : "main.rmx";

            if (File.Exists(file))
            {
                TextReader reader = File.OpenText("main.rmx");
                MyParser parser = new MyParser();
                parser.Setup();
                parser.Parse(reader);

                // Wait for user input to exit
                Console.WriteLine($"\r\n{dashes}\r\n\r\nPress any key to close this window...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No input file found.");
                Console.WriteLine($"\r\nPress any key to close this window...");
                Console.ReadKey();
            }
        }
    }
}
