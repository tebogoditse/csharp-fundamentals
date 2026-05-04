using System;
using System.IO;
using System.Collections.Generic;

public interface ILogTarget 
{ 
    void Log(string msg); 
}

public class ConsoleTarget : ILogTarget 
{
    public void Log(string msg)
    {
        Console.WriteLine("Logged: " + msg);
    }
}

public class FileTarget : ILogTarget
{
    private readonly string path;

    public FileTarget(string path)
    {
        this.path = path;
    }

    public void Log(string msg)
    {
        File.AppendAllText(path, msg + Environment.NewLine);
    }
}

public class Logger 
{
    private readonly IEnumerable<ILogTarget> targets;

    public Logger(IEnumerable<ILogTarget> targets)
    {
        this.targets = targets;
    } 
    
    public void Log(string msg)
    {
        foreach(ILogTarget target in targets)
        {
            target.Log(msg);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var targets = new List<ILogTarget>
        {
            new FileTarget(args[0]),
            new ConsoleTarget()
        };

        Logger logger = new Logger(targets);
        logger.Log(args[1]);

        Console.Write("(also appended to " + args[0]);
    }
}