using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John", "C#");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("John", "Math", "Big Math", "1, 2, 3, 4, 5");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("John", "Writing", "Big Writing");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}