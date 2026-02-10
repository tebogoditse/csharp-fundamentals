using System;

class HelloWorld
{
    string Hello;

    public static string GetHello()
    {
        HelloWorld hello = new HelloWorld();
        hello.Hello = "Hello, World!";
        return hello.Hello;
    }
    
    public static void Main()
    {
        Console.WriteLine(GetHello());
    }
}