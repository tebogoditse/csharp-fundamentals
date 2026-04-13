using System;

public class Config 
{
    public readonly string Environment;
    
    public Config(string env)
    {
        Environment = env;
    }
    
}

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Config env = new Config(input);

        Console.Write("Environment: " + env.Environment);
    }
}