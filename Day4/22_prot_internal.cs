using System;

public class FriendBase 
{ 
    protected internal void SayHi()
    {
        Console.Write("Hello from Friend");
    }
} 

public class Friend : FriendBase 
{ 
    public void Call()
    {
        SayHi();
    }
}

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input == "call")
        {
            Friend hello = new Friend();
            hello.Call();
        }
        else
        {
            Console.Write("Error! Invalid input");
        }
    }
}