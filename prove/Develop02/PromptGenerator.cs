public class PromptGenerator
{
    public List<string> _rm_prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I learned today that I didn't know yesterday?"
    };

    public string GetPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_rm_prompts.Count);
        return _rm_prompts[index];
    }
}