using System;
using System.IO;

namespace Assignment6
{
    internal class Question2
    {
        static string path = @"C:\2026\Training\C_Sharp\Assignments\Assignment6\Assignment6\mydata.bin";

        static void WriteBinary()
        {
            string[] data =
            {
                "Welcome to C#",
                "File Handling using Binary",
                "Assignment 6 Question 2",
                "Write and Read Example",
                "End of File"
            };

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                foreach (string line in data)
                {
                    writer.Write(line); 
                }
            }

            Console.WriteLine("Data written to binary file successfully.");
        }

        static void ReadBinary()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                Console.WriteLine("\nReading from binary file:\n");

                try
                {
                    while (true) 
                    {
                        Console.WriteLine(reader.ReadString());
                    }
                }
                catch (EndOfStreamException)
                {
                    
                }
            }
        }

        static void Main(string[] args)
        {
            string folder = @"C:\2026\Training\C_Sharp\Assignments\Assignment6\Assignment6";

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            WriteBinary();
            ReadBinary();

            Console.ReadLine();
        }
    }
}