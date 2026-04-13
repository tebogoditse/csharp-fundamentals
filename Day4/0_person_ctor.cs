using System;

class Person
{ 
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public override string ToString()
    {
        string result = "Name: " + name + ", Age: " + age;

        return result;
    }
}

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        Person person = new Person(inputs[0], int.Parse(inputs[1]));

        Console.Write(person.ToString());
    }
}
