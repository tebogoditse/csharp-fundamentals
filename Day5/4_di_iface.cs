using System;

public interface ILogger 
{ 
    void Log(string msg); 
}

public class ConsoleLogger : ILogger
{
    public void Log(string msg)
    {
        Console.WriteLine(msg);
    }
}

public class Service 
{
    private ILogger logger;

    public Service(ILogger logger)
    {
        this.logger = logger;
    } 
    
    public void DoWork()
    {
        logger.Log("Service started");
        logger.Log("Service finished");
    }
}

class Program
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();
        Service log = new Service(logger);

        log.DoWork();
    }
}