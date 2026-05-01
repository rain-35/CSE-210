using System;

class Program
{
    static void Main(string[] args)
    {
        int input_num = 1;
        List<int> numbers;
        numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers one at a time, type 0 when finished.");

        while (input_num != 0)
        {
            
            Console.Write("Enter a number: ");
            input_num = int.Parse(Console.ReadLine());
            if (input_num != 0)
            {
                numbers.Add(input_num);
            }
        }
        Console.WriteLine("The list is: " + string.Join(", ", numbers));

        
    }
}