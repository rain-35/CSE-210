public class Checklist : Goal
{
    private int _rm_goalCount;
    private int _rm_bonusPoints;

    public Checklist(string name, string description, int points, int goalCount, int bonusPoints, bool status = false, int timesCompletted = 0): base(name, description, points, status, timesCompletted)
    {
        _rm_type = "Checklist";
        _rm_goalCount = goalCount;
        _rm_bonusPoints = bonusPoints;
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

    public override int GetPoints()
    {
        if (_rm_timesCompletted < _rm_goalCount)
        {
            return _rm_points * _rm_timesCompletted;
        }
        else if (_rm_timesCompletted >= _rm_goalCount)
        {
            return _rm_points * _rm_goalCount + _rm_bonusPoints;
        }
        else
        {
            return 0;
        }
    }
    //non-default save string with 8 values
    public override string ToSaveString()
    {
        //0=type, 1=name, 2=description, 3=points, 4=status, 5=timesCompletted, 6=goalCount, 7=bonusPoints
        return $"{_rm_type},{_rm_name},{_rm_description},{_rm_points},{_rm_status},{_rm_timesCompletted},{_rm_goalCount},{_rm_bonusPoints}";
    }



}