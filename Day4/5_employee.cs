using System;

public class PersonBase 
{ 
    protected string role; 
} 

public class Employee : PersonBase 
{ 
    public Employee(string role)
    {
        this.role = role;
    } 
    
    public string GetRole()
    {
        return role;
    } 
}

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Employee em = new Employee(input);

        string role = em.GetRole();

        Console.Write("Role: " + role);
    }
}
