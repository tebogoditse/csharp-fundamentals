using System;

public interface ISerializable 
{ 
    string Serialize(); 
}

public interface IDeserializable 
{ 
    void Deserialize(string s); 
}

public class DataObject : ISerializable, IDeserializable 
{ 
    public string Name { get; set;}
    public int Age { get; set; }

    public string Serialize()
    {
        return "Name=" + Name + ";Age=" + Age;
    }
    
    public void Deserialize(string s)
    {
        string[] parts = s.Split(';');

        int i = 0;
        for (; i < parts.Length; i++)
        {
            string[] key = parts[i].Split('=');

            switch(key[0])
            {
                case "Name":
                    Name = key[1];
                    break;

                case "Age":
                    Age = int.Parse(key[1]);
                    break;
            }
        }

    } 
}

class Program
{
    static void Main()
    {
        DataObject obj = new DataObject();

        string input = Console.ReadLine();

        obj.Deserialize(input);

        Console.Write("Serialized: " + obj.Serialize());
    }
}