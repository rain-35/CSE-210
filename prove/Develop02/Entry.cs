public class Entry
{
    public string _rm_date;
    public string _rm_prompt_text;
    public string _rm_response_text;
    public string _rm_entry;

    public string SetEntry()
    {
        return $"{_rm_date}|{_rm_prompt_text}|{_rm_response_text}";
    }

    public void GetEntry(string rmLine)
    {
        string[] parts = rmLine.Split('|');
        _rm_date = parts[0];
        _rm_prompt_text = parts[1];
        _rm_response_text = parts[2];
    }
    public void Display()
    {
        Console.WriteLine($"Date {_rm_date}, Prompt {_rm_prompt_text}");
        Console.WriteLine(_rm_response_text);
    }

}