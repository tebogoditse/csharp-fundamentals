using System;

public class AppInfo 
{ 
    public string Name { get; init; } 
    
    public int Version {get; init; } 
    
}

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();

        string[] str = s.Split(' ');

        AppInfo app = new AppInfo
        {
            Name = str[0].Split("=")[1],
            Version = int.Parse(str[1].Split("=")[1])
        };

        Console.Write(app.Name + " v" + app.Version);
    }
}