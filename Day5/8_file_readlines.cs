using System;
using System.IO;

public class FileReader 
{ 
    public string[] ReadLines(string path)
    {
        return File.ReadAllLines(path);
    }
}

class Program
{
    static void Main(string[] args)
    {
        FileReader readFile = new FileReader();
        string[] lines = readFile.ReadLines(args[0]);

        int i = 0;
        for (; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}