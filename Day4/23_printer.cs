using System;

public interface IPrintable 
{ 
    void Print(); 
} 

public class Document : IPrintable 
{
    public string Doc { get; set; }

    public void Print()
    {
        Console.WriteLine("Printing document: " + Doc);
    } 
} 

public class Image : IPrintable 
{ 
    public string Img { get; set; }

    public void Print()
    {
        Console.WriteLine("Printing image: " + Img);
    }
} 

public class Printer 
{ 
    public void Print(IPrintable p)
    {
        p.Print();
    } 
}

class Program
{
    static void Main()
    {
        Printer printer = new Printer();

        string input;
        while ((input = Console.ReadLine()) != null && input != "")
        {
            string[] inputs = input.Split(' ');
            if (inputs.Length != 2 || (inputs[0] != "Document" && inputs[0] != "Image"))
            {
                Console.WriteLine("Error");
                continue;
            }

            if (inputs[0] == "Document")
            {
                Document doc = new Document();
                doc.Doc = inputs[1];
                printer.Print(doc);
            }
            else if (inputs[0] == "Image")
            {
                Image img = new Image();
                img.Img = inputs[1];
                printer.Print(img);
            }
        }
        
    }
}