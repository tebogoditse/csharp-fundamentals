using System;

public interface ISerializable 
{ 
    string Serialize(); 
} 

public class Person : ISerializable 
{ 
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public string Serialize()
    {
        string json = "{\"Name\":\"" + Name + "\",\"Age\":" + Age + "}";
        return json;
    }
}

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');

        string name = inputs[0];
        int age = int.Parse(inputs[1]);
        
        Person person = new Person(name, age);

        Console.Write(person.Serialize());
    }
}