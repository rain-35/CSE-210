using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = GetUserName();
        int number = GetUserNumber();
        int birthYear = GetBirthYear();
        int square = SquareNumber(number);
        DisplayUserInfo(name, square, birthYear);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }

    static int GetUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int GetBirthYear()
    {
        Console.WriteLine("Please enter your birth year: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayUserInfo(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"You will turn {2026 - birthYear} this year.");
    }
}