using System;

public class Profile 
{ 
    public string Username { get; set; } 
    private string email; 
    
    public Profile(string username, string email)
    {
        Username = username;
        this.email = email;
    }
    
    public string GetEmail()
    {
        return email;
    } 
}

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');

        string username = inputs[0];
        string email = inputs[1];

        Profile prof = new Profile(username, email);

        Console.WriteLine("Username: " + prof.Username);
        Console.Write("Email: " + prof.GetEmail());
    }
}