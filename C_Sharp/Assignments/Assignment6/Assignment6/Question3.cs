using System;
using System.IO;

namespace Assignment6
{
    internal class Question3
    {
        static string path = @"C:\2026\Training\C_Sharp\Assignments\Assignment6\Assignment6\myfile.txt";

        static void WriteFile()
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("Welcome to C#");
                sw.WriteLine("File Handling Example");
                sw.WriteLine("Counting number of lines");
                sw.WriteLine("Assignment 6 Question 3");
                sw.WriteLine("End of File");
            }

            Console.WriteLine("File created and data written successfully.\n");
        }

        static void CountLines()
        {
            int count = 0;

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                }
            }

            Console.WriteLine("Number of lines in the file: " + count);
        }

        static void Main(string[] args)
        {
            string folder = @"C:\2026\Training\C_Sharp\Assignments\Assignment6\Assignment6";

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            WriteFile();  
            CountLines();  

            Console.ReadLine();
        }
    }
}