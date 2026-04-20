using System;

public enum Mode 
{ 
    Read, 
    Write, 
    Append 
} 

public static class ModeHelper 
{
    public static Mode Parse(string s)
    {
        object tmp = Enum.Parse(typeof(Mode), s, ignoreCase: true);
        Mode result = (Mode)tmp;

        return result;
    }
    
    public static string Describe(Mode m)
    {
        string resultString;

        if (m == Mode.Read)
        {
            resultString = "reads content";
        }
        else if (m == Mode.Write)
        {
            resultString = "writes new content";
        }
        else if (m == Mode.Append)
        {
            resultString = "appends content to a file";
        }
        else
        {
            throw new InvalidOperationException("Unknown mode");
        }

        return resultString;
    }
}

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Mode mode = ModeHelper.Parse(input);

        Console.Write("Mode: " + mode + " (" + ModeHelper.Describe(mode) +" )");
    }
}