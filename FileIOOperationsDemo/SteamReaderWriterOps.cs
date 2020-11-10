using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOOperationsDemo
{
    public class SteamReaderWriterOps
    {
        public void WriteUsingStreamWriter()
        {
            string path = @"C:\Users\admin\source\repos\FileIOOperationsDemo\FileIOOperationsDemo";

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine("operations using stream writer and reader");

                streamWriter.Close();

                Console.WriteLine(File.ReadAllText(path));

            }

            Console.ReadKey();
        }

        public void ReadUsingStreamReader()
        {
            string path = @"C:\Users\admin\source\repos\FileIOOperationsDemo\FileIOOperationsDemo";

            using (StreamReader streamReader = File.OpenText(path))
            {
                string text = " ";

                while ((text = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                }
                Console.ReadKey();
            }
        }
    }
}
