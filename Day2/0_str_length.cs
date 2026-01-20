using System;

class StrLength
{
    public string strlen;

    static void PrintStringLength()
    {
        StrLength str = new StrLength();

        str.strlen = Console.ReadLine();

        Console.Write(str.strlen.Length);
    }

    static void Main()
    {
        PrintStringLength();
    }
}