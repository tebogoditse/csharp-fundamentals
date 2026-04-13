using System;

public abstract class Processor 
{ 
    public string Input { get; set; }
    public void Process()
    {
        Input = Console.ReadLine();

        string output = Step(Input);
        Console.Write("Processed: " + output);
    } 
    
    protected abstract string Step(string input); 
} 

public class MyProcessor : Processor 
{ 
    protected override string Step(string input)
    {
        return input;
    }
}

class Program
{
    static void Main()
    {
        Processor processor = new MyProcessor();

        processor.Process();
    }
}