using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        int low = 0;
        int high = 10;
        int guesses = 0;

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(low, high + 1);
            // Console.WriteLine(number);   
            
            while (true)
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                int guess_num = int.Parse(guess);
                guesses++;
                if (guess_num == number)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine("You took " + guesses + " guesses.");
                    break;
                }else if (guess_num > number)
                {
                    Console.WriteLine("Lower");
                }else if (guess_num < number)
                {
                    Console.WriteLine("Higher");
                }
                

            }

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();

        }





    }
}