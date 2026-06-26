using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();

        while (true)
        {
            int choice = 0;

            

            Console.Clear();
            gm.ShowScore();
            Console.WriteLine("\nMenu options");
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Enter your choice");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                gm.CreateGoal();
            } 
            else if (choice == 2)
            {
                gm.ListGoals();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else if (choice == 3)
            {
                gm.SaveGoals();
            }
            else if (choice == 4)
            {
                gm.LoadGoals();
            }
            else if (choice == 5)
            {
                gm.EventRecorder();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Thank you for using the Mindfulness App!");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid choice. Please try again.\n");
            }
        }
    }
}