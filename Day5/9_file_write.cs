using System;
using System.IO;

public class FileWriter 
{ 
    public void WriteText(string path, string content)
    {
        File.WriteAllText(path, content);
        int data = System.Text.Encoding.UTF8.GetByteCount(content);
        Console.WriteLine("Wrote " + data + " bytes to " + path);
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