using System;

public abstract class Logger 
{ 
    public abstract void Log(string message); 
}

public class ConsoleLogger : Logger 
{ 
    public override void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main()
    {
        string message = Console.ReadLine();

        Logger log = new ConsoleLogger();

        log.Log(message);
    }
}