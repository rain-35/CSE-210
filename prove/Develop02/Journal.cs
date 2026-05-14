public class Journal
{
    public string _rm_fileName;
    public List<Entry> _rm_entries = new List<Entry>();
    
    public void DisplayJournal()
    {
        foreach (Entry entry in _rm_entries)
        {
            entry.Display();
        }
    }

    public void AddEntry(Entry newEntry)
    {
        _rm_entries.Add(newEntry);

    }

    public void SaveJournal(string file)
    {
        // string rmFileLocation = $"prove/Develop02/{file}";
        using (StreamWriter outputfile = new StreamWriter(file))
        {
            foreach (Entry entry in _rm_entries)
            {
                outputfile.WriteLine($"{entry._rm_date}|{entry._rm_prompt_text}|{entry._rm_response_text}");
            }
        }
    
    }

    public void LoadJournal(string file)
    {
        // string rmFileLocation = $"prove/Develop02/{file}";
        _rm_entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry newEntry = new Entry();
            newEntry._rm_date = parts[0];
            newEntry._rm_prompt_text = parts[1];
            newEntry._rm_response_text = parts[2];

            _rm_entries.Add(newEntry);
        }
    }

}