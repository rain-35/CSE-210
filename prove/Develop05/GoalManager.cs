public class GoalManager
{
    private List<Goal> _rm_goalList;
    private List<String> _rm_loadList;
    private int _rm_score;
    private int choice;
    private int x;

    public GoalManager()
    {
        _rm_goalList = new List<Goal>();
        _rm_loadList = new List<string>();
    }
    public void CalculateScore()
    {
        _rm_score = 0;
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
        choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is the a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("How many points should it be worth? ");
        int points = int.Parse(Console.ReadLine());
        
        if (choice == 1)
        {
            Console.WriteLine("Creating a simple goal");
            Simple s = new Simple(name, description, points);
            _rm_goalList.Add(s);
            s.ToShortString();
        }
        else if (choice == 2)
        {
            Console.WriteLine("Creating an eternal goal");
            Eternal e = new Eternal(name, description, points);
            _rm_goalList.Add(e);
            e.ToShortString();
        }
        else if (choice == 3)
        {
            Console.WriteLine("Creating a checklist goal");
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalCount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            Checklist c = new Checklist(name, description, points, goalCount, bonusPoints);
            _rm_goalList.Add(c);
            c.ToShortString();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
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

    public void EventRecorder()
    {
        Console.Clear();
        ListGoals();
        Console.WriteLine("Enter the number of the goal you would like to record an event for: ");
        choice = int.Parse(Console.ReadLine());
        

        if (choice > 0 && choice <= _rm_goalList.Count)
        {
            choice = choice - 1;
            Console.WriteLine("Would you like to record an event for this goal?");
            Console.WriteLine($"{_rm_goalList[choice].ToShortString()}");
            Console.Write("Enter 1 for yes or 0 for no: ");
            x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                _rm_goalList[choice].RecordEvent();
            }
            else
            {
                Console.WriteLine("Canceled");
            }

        }
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.WriteLine("What should the file be named?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal g in _rm_goalList)
            {
                outputFile.WriteLine(g.ToSaveString());
            }
        }    
    }  

    public void LoadGoals()
    {
        Console.Clear();
        Console.WriteLine("This will clear your current list of goals.\nPress enter to continue or 1 to cancel.");
        if (Console.ReadLine() == "1")
        {
            Console.WriteLine("Canceled");
            return;
        }

        Console.Clear();
        Console.WriteLine("What is the name of the file you would like to load?");
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        _rm_loadList.Clear();
        _rm_goalList.Clear();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            _rm_loadList.Add(line);
        }
        
        foreach (string line in _rm_loadList)
        {
            string[] values = line.Split(',');
            
            if (values[0] == "Simple")
            {
                //0=type, 1=name, 2=description, 3=points, 4=status, 5=timesCompletted
                Simple s = new Simple(values[1], values[2], int.Parse(values[3]), bool.Parse(values[4]), int.Parse(values[5]));
                _rm_goalList.Add(s);
            }   
            else if (values[0] == "Eternal")
            {
                //0=type, 1=name, 2=description, 3=points, 4=status, 5=timesCompletted
                Eternal e = new Eternal(values[1], values[2], int.Parse(values[3]), bool.Parse(values[4]), int.Parse(values[5]));
                _rm_goalList.Add(e);
            }
            else if (values[0] == "Checklist")
            {
                //0=type, 1=name, 2=description, 3=points, 4=status, 5=timesCompletted, 6=goalCount, 7=bonusPoints
                //loader 1=name, 2=description, 3=points, 4=goalCount, 5=bonusPoints, 6=status, 7=timesCompletted
                Checklist c = new Checklist(values[1], values[2], int.Parse(values[3]), int.Parse(values[6]), int.Parse(values[7]), bool.Parse(values[4]), int.Parse(values[5]));
                _rm_goalList.Add(c);
            }
            else
            {
                Console.WriteLine("Invalid format");
            }
        }    
        
    }
}