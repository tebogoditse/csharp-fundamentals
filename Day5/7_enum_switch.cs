using System;

public enum LogLevel 
{ 
    Debug, 
    Info, 
    Warning, 
    Error 
} 

public class Logger 
{
    public void Log(LogLevel level, string message)
    {
        switch(level)
        {
            case LogLevel.Debug:
                Console.Write("[DEBUG] " + message);
                break;
            case LogLevel.Info:
                Console.Write("[INFO] " + message);
                break;
            case LogLevel.Warning:
                Console.Write("[WARNING] " + message);
                break;
            case LogLevel.Error:
                Console.Write("[ERROR] " + message);
                break;
            default:
                Console.Write(message);
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        object tmp = Enum.Parse(typeof(LogLevel), input[0], ignoreCase: true);

        LogLevel level = (LogLevel)tmp;
        
        string message = string.Join(" ", input, 1, input.Length - 1);

        Logger logger = new Logger();

        logger.Log(level, message);
    }
}