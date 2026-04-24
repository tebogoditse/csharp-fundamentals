using System;
using System.IO;

public interface IPersist 
{ 
    void Save(string path); 
} 

public class User : IPersist 
{ 
    public string Name { get; set; }
    public int Age { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Save(string path)
    {
        string content = "Name: " + Name + ", Age: " + Age;
        File.WriteAllText(path, content);
        Console.Write("File saved to " + path);
    } 
}

class Program
{
    static void Main(string[] args)
    {
        string path = args[0];
        string name = args[1];
        int age = int.Parse(args[2]);

        IPersist user = new User(name, age);
        user.Save(path);
    }
}