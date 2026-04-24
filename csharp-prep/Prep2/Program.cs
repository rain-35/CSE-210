using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage? ");
        float grade_num = float.Parse(Console.ReadLine());

        string grade_let = "error";


        if (grade_num >= 90)
        {
            grade_let = "A";
        }
        else if (grade_num >= 80)
        {
            grade_let = "B";
        }
        else if (grade_num >= 70)
        {
            grade_let = "C";
        }
        else if (grade_num >= 60)
        {
            grade_let = "D";
        }
        else
        {
            grade_let = "F";
        }

        Console.WriteLine($"Your grade is {grade_let}.");

        if (grade_num >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed.");
        }
        
    }
}