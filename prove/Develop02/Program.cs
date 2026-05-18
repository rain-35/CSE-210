// Program.cs
// journal program
// Created by Rainen Morriss
// CSE 210 Spring 2026
// started 5/13/26
// sources 
//    class material
//    google.com
//    AI


using System;

class Program
{
    static void Main(string[] args)
    {
        Journal rmTheJournal = new Journal();
        PromptGenerator rmPromptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the journal program!");
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string rmPrompt = rmPromptGenerator.GetPrompt();
                Console.WriteLine(rmPrompt);
                Console.WriteLine(">");
                string rmResponse = Console.ReadLine();
                string rmDate = DateTime.Now.ToShortDateString();

                Entry rmNewEntry = new Entry();
                rmNewEntry._rm_date = rmDate;
                rmNewEntry._rm_prompt_text = rmPrompt;
                rmNewEntry._rm_response_text = rmResponse;

                rmTheJournal.AddEntry(rmNewEntry);
            }
            else if (choice == 2)
            {
                rmTheJournal.DisplayJournal();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter the name of the journal file");
                string rmFileName = Console.ReadLine();
                rmTheJournal.LoadJournal(rmFileName);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter the name of the journal file");
                string rmFileName = Console.ReadLine();
                rmTheJournal.SaveJournal(rmFileName);
            }
            else if (choice == 5)
            {
                break;
            }
        }
    }   
}