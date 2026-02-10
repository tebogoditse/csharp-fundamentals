using System;

class Grade
{
    int number;

    static void GradeCalc()
    {
        Grade n = new Grade();
        int grade = n.number = int.Parse(Console.ReadLine());

        switch (grade)
        {
            case int g when g >= 90 && g <= 100:
                Console.Write('A');
                break;

            case int g when g >= 80 && g <= 89:
                Console.Write('B');
                break;

            case int g when g >= 70 && g <= 79:
                Console.Write('C');
                break;

            case int g when g >= 60 && g <= 69:
                Console.Write('D');
                break;
            default:
                Console.Write('F');
                break;
        }
    }

    static void Main()
    {
        GradeCalc();
    }
}