// Program.cs
// CSE-210
// Created by Rainen Morriss on 6/11/26
// Sources
//    class material
//    google
//    AI
//    stackoverflow
// Above and beyond
// I improved the code by adding the ability to list the activities completed


using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> activities = new List<string>();
        Activity a1 = new Activity("temp","temp");
        Listing listing = new Listing();
        Reflection reflection = new Reflection();
        Breathing breathing = new Breathing();
        int choice = 0;

        Console.WriteLine("Welcome to the Mindfulness App!");
        while (true)
        {
    
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Activities Completed");
            Console.WriteLine("5. Quit");
            int.TryParse(Console.ReadLine(),out choice);

            if (choice == 1)
            {                
                breathing.Run();
                activities.Add("Breathing");
            }
            else if (choice == 2)
            {                
                reflection.Run();
                activities.Add("Reflection");
            }
            else if (choice == 3)
            {                
                listing.Run();
                activities.Add("Listing");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Activities Completed");
                foreach (string activity in activities)
                {
                    Console.WriteLine(activity);
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using the Mindfulness App!");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid choice. Please try again.");
                a1.ShowSpinner(1);
                Console.Clear();
            }
            
            
        }
    }
}