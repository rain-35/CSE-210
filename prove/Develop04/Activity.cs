using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected string _rm_name;
    protected string _rm_description;
    protected int _rm_duration;
    protected string _rm_startMessage;
    protected string _rm_closeMessage;

    public Activity(string rmName, string rmDescription)
    {
        _rm_name = rmName;
        _rm_description = rmDescription;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_rm_name} Activity.\n");
        Console.WriteLine(_rm_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _rm_duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(1);
        Console.Clear();
        Console.WriteLine($"You have completed another {_rm_duration} seconds of the {_rm_name} Activity.");
        ShowSpinner(2);
        Console.Clear();

    }

    public void ShowSpinner(int rmSeconds)
    {
        List<string> spinnerFrames = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(rmSeconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerFrames[i % spinnerFrames.Count]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }

    }

    public void ShowCountdown(int rmSeconds)
    {
        for (int i = rmSeconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }





}