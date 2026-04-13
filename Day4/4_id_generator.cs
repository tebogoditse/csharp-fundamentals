using System;

class IdGenerator 
{ 
    private static int NextId; 
    
    static IdGenerator()
    {
        NextId = 1000;
    }

    public static int Generate()
    {
        int increment = ++NextId;

        return increment;
    } 
}

class Program
{
    static void Main()
    {
        int result = IdGenerator.Generate();

        Console.Write(result);
    }
}