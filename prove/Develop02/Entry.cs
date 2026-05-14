public class Entry
{
    public string _rm_date;
    public string _rm_prompt_text;
    public string _rm_response_text;

    public void Display()
    {
        Console.WriteLine($"Date {_rm_date}, Prompt {_rm_prompt_text}");
        Console.WriteLine(_rm_response_text);
    }

}