using System;

class AgeCategory
{
    public int years;

    static void CategorizeAge()
    {
        AgeCategory age = new AgeCategory();
        age.years = int.Parse(Console.ReadLine());

        if (age.years < 0)
        {
            Console.Write("Error: Age cannot be negative");
        }
        else if (age.years > -1 && age.years < 13)
        {
            Console.Write("Child");
        }
        else if (age.years > 12 && age.years < 20)
        {
            Console.Write("Teen");
        }
        else if (age.years > 19 && age.years < 60)
        {
            Console.Write("Adult");
        }
        else
        {
            Console.Write("Senior");
        }
    }

    static void Main()
    {
        CategorizeAge();
    }
}