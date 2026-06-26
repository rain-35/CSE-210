public class Eternal : Goal
{
    public Eternal(string name, string description, int points, bool status = false, int timesCompletted = 0): base(name, description, points, status, timesCompletted)
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

    //default save string with 6 values


}