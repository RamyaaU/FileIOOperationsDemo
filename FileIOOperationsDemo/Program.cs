using System;
using System.IO;

namespace FileIOOperationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to File Input and Output operations!");

            // Program.FileExists();
           // Program.ReadAllLine();
           // Program.ReadAllText();
            SteamReaderWriterOps operations = new SteamReaderWriterOps();

            operations.WriteUsingStreamWriter();
            operations.ReadUsingStreamReader();
        }

        public static void FileExists()
        {
            string path = "C:/Users/admin/source/repos/FileIOOperationsDemo/FileIOOperationsDemo/Example.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("file exists");
            }

            Console.ReadKey();
        }

        public static void ReadAllLine()
        {
            string path = @"C:\Users\admin\source\repos\FileIOOperationsDemo\FileIOOperationsDemo";
            string[] Lines;
            Lines = File.ReadAllLines(path);
            Console.WriteLine(Lines[0]);
            Console.WriteLine(Lines[1]);
            Console.ReadKey();
        }

        public static void ReadAllText()
        {
            string path = @"C:\Users\admin\source\repos\FileIOOperationsDemo\FileIOOperationsDemo";

            string lines;

            lines = File.ReadAllText(path);
            Console.WriteLine("lines");

            Console.ReadKey();
        }
    }
}
