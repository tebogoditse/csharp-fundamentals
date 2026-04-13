using System;

public class Person 
{ 
    private int age; 
    public int Age { 
        get {return age; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();
            age = value;
        }
    } 
    
    public Person(int age)
    {
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());

        Person person = new Person(age);

        Console.Write("Age set to " + person.Age);
    }
}