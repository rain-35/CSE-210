public class Eternal : Goal
{
    public Eternal(string name, string description, int points): base(name, description, points)
    {
        _rm_type = "Eternal";
    }
    
    public override void RecordEvent()
    {
        _rm_timesCompletted++;
    }

    public override int GetPoints()
    {
        return _rm_points * _rm_timesCompletted;
    }


}