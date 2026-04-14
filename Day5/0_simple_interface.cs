using System;

public interface IPrinter 
{ 
    void Print(string text); 
} 

public class ConsolePrinter : IPrinter 
{ 
    public void Print(string text)
    {
        Console.Write(text);
    }
}

class Program
{
    static void Main()
    {
        ConsolePrinter printer = new ConsolePrinter();

        string text = Console.ReadLine();

        printer.Print(text);
    }
}