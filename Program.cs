using System;
using System.IO;

namespace maliwc
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || args.Length == 1 && args[0].StartsWith("-"))
            {
                string input = Console.In.ReadToEnd();
                CountFromInput(input, args.Length > 0 ? args[0] : "");
                return;
            }

            string option = args.Length > 1 ? args[0] : "";
            string filePath = args.Length > 1 ? args[1] : args[0];

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} does not exist.");
                return;
            }

            switch (option)
            {
                case "-c":
                    CountBytes(filePath);
                    break;
                case "-l":
                    CountLines(filePath);
                    break;
                case "-w":
                    CountWords(filePath);
                    break;
                case "-m":
                    CountCharacters(filePath);
                    break;
                case "":
                    CountAll(filePath);
                    break;
                default:
                    Console.WriteLine("Invalid option. Use -c for bytes, -l for lines, -w for words, -m for characters.");
                    break;
            }
        }

        static void CountBytes(string filePath)
        {
            long byteCount = new FileInfo(filePath).Length;
            Console.WriteLine($"{byteCount} {filePath}");
        }

        static void CountLines(string filePath)
        {
            int lineCount = File.ReadAllLines(filePath).Length;
            Console.WriteLine($"{lineCount} {filePath}");
        }

        static void CountWords(string filePath)
        {
            int wordCount = 0;
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                wordCount += line.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }

            Console.WriteLine($"{wordCount} {filePath}");
        }

        static void CountCharacters(string filePath)
        {
            string content = File.ReadAllText(filePath);
            int charCount = content.Length;
            Console.WriteLine($"{charCount} {filePath}");
        }

        static void CountAll(string filePath)
        {
            long byteCount = new FileInfo(filePath).Length;
            int lineCount = File.ReadAllLines(filePath).Length;
            int wordCount = 0;
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                wordCount += line.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }

            Console.WriteLine($"{lineCount} {wordCount} {byteCount} {filePath}");
        }

        static void CountFromInput(string input, string option)
        {
            int lineCount = input.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int wordCount = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int charCount = input.Length;

            switch (option)
            {
                case "-c":
                    Console.WriteLine($"{charCount}");
                    break;
                case "-l":
                    Console.WriteLine($"{lineCount}");
                    break;
                case "-w":
                    Console.WriteLine($"{wordCount}");
                    break;
                case "-m":
                    Console.WriteLine($"{charCount}");
                    break;
                default:
                    Console.WriteLine($"{lineCount} {wordCount} {charCount}");
                    break;
            }
        }
    }
}

