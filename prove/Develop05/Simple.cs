public class Simple : Goal
{
    public Simple(string name, string description, int points, bool status = false, int timesCompletted = 0): base(name, description, points, status, timesCompletted)
    {
        _rm_type = "Simple";
    }

    public override int GetPoints()
    {
        return _rm_points;
    }

    public override void RecordEvent()
    {
        _rm_status = true;
        _rm_checkbox = "[x]";
        _rm_timesCompletted++;
    }

    //default save string with 6 values

}