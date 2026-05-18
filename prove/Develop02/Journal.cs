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
        Console.WriteLine();
    }

    public void AddEntry(Entry newEntry)
    {
        _rm_entries.Add(newEntry);
        newEntry.SetEntry();
    }

    public void SaveJournal(string file)
    {
        // string rmFileLocation = $"prove/Develop02/{file}";
        using (StreamWriter outputfile = new StreamWriter(file))
        {
            foreach (Entry entry in _rm_entries)
            {
                outputfile.WriteLine(entry.SetEntry());
            }
        }
    
    }

    public void LoadJournal(string file)
    {
        _rm_entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry rmTheEntry = new Entry();
            rmTheEntry.GetEntry(line);
            _rm_entries.Add(rmTheEntry);
        }
    }

}