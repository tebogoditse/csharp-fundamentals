using System;
using System.IO;

public class FileAppender 
{ 
    public void Append(string path, string line)
    {
        if (File.Exists(path) && new FileInfo(path).Length > 0)
        {
            string text = File.ReadAllText(path);
            if (text.EndsWith(Environment.NewLine))
                File.AppendAllText(path, line + Environment.NewLine);
            else
                File.AppendAllText(path, Environment.NewLine + line + Environment.NewLine);
        }
        else
        {
            File.AppendAllText(path, line + Environment.NewLine);
        }

        Console.WriteLine("Appended 1 line to " + path);
    } 
}

class Program
{
    static void Main(string[] args)
    {
        FileAppender append = new FileAppender();

        string path = args[0];
        string line = args[1];

        append.Append(path, line);
    }
}