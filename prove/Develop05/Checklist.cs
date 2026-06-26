public class Checklist : Goal
{
    private int _rm_goalCount;
    private int _rm_bonusPoints;

    public Checklist(string name, string description, int points, int goalCount, int bonusPoints): base(name, description, points)
    {
        _rm_type = "Checklist";
    }
    
    public override void RecordEvent()
    {
        _rm_timesCompletted++;
        if (_rm_timesCompletted >= _rm_goalCount)
        {
            _rm_status = true;
            _rm_checkbox = "[x]";
        }
    }



}