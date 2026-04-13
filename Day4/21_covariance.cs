using System;

class Program
{
    static string GetString()
    {
        string s = "example string";
        return s;
    }

    static void Main()
    {
        Func<string> strProducer = GetString;
        Func<object> objProducer = strProducer;

        object producer = objProducer();

        Console.Write("Produced: " + producer);
    }
}