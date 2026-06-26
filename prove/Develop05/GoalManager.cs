public class GoalManager
{
    private List<Goal> _rm_goalList;
    private int _rm_score;
    private int choice;
    private int x;

    public void CalculateScore()
    {
        foreach (Goal g in _rm_goalList)
        {
            if (g.IsComplete())
            {
                _rm_score += g.GetPoints();
            }
        }
    }

    public void ShowScore()
    {
        CalculateScore();
        Console.WriteLine($"You have {_rm_score} points.");
    }

    public void CreateGoal()
    {
        Console.Clear();
        choice = 0;
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("What type of goal would you like to create?");

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is the a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("How many points should it be worth? ");
        int points = int.Parse(Console.ReadLine());
        
        if (choice == 1)
        {
            Simple s = new Simple(name, description, points);
            _rm_goalList.Add(s);
        }
        else if (choice == 2)
        {
            Eternal e = new Eternal(name, description, points);
            _rm_goalList.Add(e);
        }
        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalCount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            Checklist c = new Checklist(name, description, points, goalCount, bonusPoints);
            _rm_goalList.Add(c);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    public void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("Goals:");
        x = 1;
        foreach (Goal g in _rm_goalList)
        {
            Console.WriteLine($"{x}. {g.ToShortString()}");
            x++;
        }
        
    }

    public void eventRecorder()
    {
        ListGoals();
        Console.WriteLine("What goal would you like to record an event for?");
        Console.Write("Enter the number of the goal you would like to record an event for: ");
        choice = int.Parse(Console.ReadLine());
        choice = choice - 1;

        if (choice > 0 && choice <= _rm_goalList.Count)
        {
            Console.WriteLine("Would you like to record an event for this goal?");
            Console.WriteLine($"{x}. {_rm_goalList[choice].ToShortString()}");
            Console.Write("Enter 1 for yes or 2 for no: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                _rm_goalList[choice].RecordEvent();
            }
            else
            {
                Console.WriteLine("Canceled");
            }

        }
    }
}