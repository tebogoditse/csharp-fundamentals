using System;

public sealed class Greeter 
{ 
    public string Greet(string name)
    {
        return "Hello, " + name; 
    } 
}

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();

        Greeter greeter = new Greeter();

        Console.Write(greeter.Greet(name));
    }
}