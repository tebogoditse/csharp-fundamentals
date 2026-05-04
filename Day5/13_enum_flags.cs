using System;

[Flags] 
public enum Permissions 
{ 
    Read=1, 
    Write=2, 
    Execute=4 
}

public static class PermHelper 
{ 
    public static Permissions Parse(string s)
    {
        object tmp = Enum.Parse(typeof(Permissions), s, ignoreCase: true);
        Permissions permissions = (Permissions)tmp;

        return permissions;
    }

    public static string Describe(Permissions p)
    {
        return p.ToString();
    }
}

class Program
{
    static void Main()
    {
        Permissions perms = PermHelper.Parse(Console.ReadLine());

        Console.WriteLine(PermHelper.Describe(perms));       
    }
}