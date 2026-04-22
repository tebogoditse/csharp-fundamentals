using System;
using System.IO;

public class FileWriter 
{ 
    public void WriteText(string path, string content)
    {
        File.WriteAllText(path, content);
        Console.WriteLine("File written successfully.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        FileWriter write = new FileWriter();

        string path = args[0];
        string content = args[1];

        write.WriteText(path, content);
    }
}