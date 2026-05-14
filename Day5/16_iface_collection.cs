using System;
using System.Collections.Generic;

public interface IProcessor 
{ 
    string Process(string s); 
}

public class UpperCaseProcessor : IProcessor
{
    public string Process(string s)
    {
        return s.ToUpper();
    }
}

public class ReverseProcessor : IProcessor
{
    public string Process(string s)
    {
        string reversed = String.Empty;

        int i = s.Length - 1;
        for (; i >= 0; i--)
        {
            reversed = reversed + s[i];
        }

        return reversed.ToLower();
    }
}

public class Pipeline 
{ 
    IEnumerable<IProcessor> processors;

    public Pipeline(IEnumerable<IProcessor> processors)
    {
        this.processors = processors;
    } 
    
    public string Run(string input)
    { 
        foreach(IProcessor processor in processors)
        {
            input = processor.Process(input);
        }

        return input;
    } 
}


class Program
{
    static void Main(string[] args)
    {
        List<IProcessor> processor = new List<IProcessor>
        {
            new UpperCaseProcessor(),
            new ReverseProcessor()
        };

        Pipeline pipeline = new Pipeline(processor);

        string input = args[0];

        string result = pipeline.Run(args[0]);

        Console.Write(input.ToUpper() + " -> " + result);
    }
}