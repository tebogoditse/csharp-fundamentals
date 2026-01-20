using System;

class ToLower
{
    public string str;

    static void ConvertToLowercase()
    {
        ToLower str_lower = new ToLower();
        str_lower.str = Console.ReadLine();

        Console.Write(str_lower.str.ToLower());
    }

    static void Main()
    {
        ConvertToLowercase();
    }
}