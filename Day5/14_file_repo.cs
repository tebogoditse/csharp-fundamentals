using System;
using System.IO;
using System.Collections.Generic;

public class FileRepository 
{ 
    public void AddRecord(string path, string record)
    {
        File.AppendAllText(path, record + Environment.NewLine);
    }
    
    public IEnumerable<string> ReadAll(string path)
    {
        return File.ReadLines(path);
    }
}

class Program
{
    static void Main(string[] args)
    {
        FileRepository repo = new FileRepository();

        if (args[1] == "read")
        {
            foreach(var line in repo.ReadAll(args[0]))
            {
                Console.WriteLine(line);
            }
        }
        else if (args[1] == "add")
        {
            repo.AddRecord(args[0], args[2]);
            Console.WriteLine("Added record to " + args[0]);
        }
        else
        {
            Console.Write("Unknown command");
        }
    }
}