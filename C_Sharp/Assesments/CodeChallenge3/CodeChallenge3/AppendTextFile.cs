using System;
using System.IO;

namespace CodeChallenge3
{
    internal class AppendTextFile
    {
        static void Main()
        {
            string fileName = "C:\\2026\\Training\\C_Sharp\\Assesments\\CodeChallenge3\\CodeChallenge3\\textfile.txt";

            Console.WriteLine("Enter text to append to the file:");
            string text = Console.ReadLine();

            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(text);

            sw.Close();
            fs.Close();

            Console.WriteLine("Text appended successfully.....");
            Console.ReadLine();
        }
    }
}