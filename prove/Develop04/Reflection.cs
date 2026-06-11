public class Reflection : Activity
{
    private List<string> _rm_unusedQuestions;
    private List<string> _rm_unusedPrompts;
    private List<string> _rm_prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _rm_questions = new List<string>
    {            
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}

    private string GetRandomQuestion()
    {
        if (_rm_unusedQuestions.Count == 0)
        {
            _rm_unusedQuestions = _rm_questions;
        }

        Random random = new Random();
        int index = random.Next(0, _rm_unusedQuestions.Count);
        string question = _rm_unusedQuestions[index];
        _rm_unusedQuestions.RemoveAt(index);

        return question;
    }

    private string GetRandomPrompt()
    {
        if (_rm_unusedPrompts.Count == 0)
        {
            _rm_unusedPrompts = _rm_prompts;
        }

        Random random = new Random();
        int index = random.Next(0, _rm_unusedPrompts.Count);
        string prompt = _rm_unusedPrompts[index];
        _rm_unusedPrompts.RemoveAt(index);

        return prompt;

    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        

        Console.WriteLine("Consider the following question:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience. press enter for a new question.");
        ShowSpinner(1);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_rm_duration);
        while (DateTime.Now < endTime)
        {
            
            Console.WriteLine(GetRandomQuestion());
            Console.ReadLine();
        }

        DisplayEndingMessage();

    }
}

    