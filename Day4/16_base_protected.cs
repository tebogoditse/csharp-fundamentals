using System;

public class Base 
{ 
    protected string title;

    protected Base(string title)
    {
        this.title = title;
    }
} 

public class Derived : Base 
{ 
    public Derived(string title) : base(title){}

    public override string ToString()
    {
        return "Report Title: " + title;
    }
}

class Program
{
    static void Main()
    {
        string report = Console.ReadLine();

        Derived title = new Derived(report);

        Console.Write(title.ToString());
    }
}