public abstract class Goal
{
    protected string _rm_type;
    protected string _rm_name;
    protected string _rm_description;
    protected int _rm_points;
    protected bool _rm_status;
    protected int _rm_timesCompletted;
    protected string _rm_checkbox;

    public Goal(string name, string description, int points, bool status, int timesCompletted)
    {
        _rm_name = name;
        _rm_description = description;
        _rm_points = points;
        _rm_status = status;
        _rm_timesCompletted = timesCompletted;
        if (status == true)
        {
            _rm_checkbox = "[x]";
        }
        else
        {
            _rm_checkbox = "[ ]";
        }

    }

    public bool IsComplete()
    {
        return _rm_status;
    }
    
    public virtual string ToShortString()
    {
        return $"{_rm_checkbox} {_rm_type} Goal: {_rm_name} ({_rm_description})";
    }

    public abstract int GetPoints();
    public abstract void RecordEvent();
    
    public virtual string ToSaveString()
    {
        //default save string with 6 values
        //0=type, 1=name, 2=description, 3=points, 4=status, 5=timesCompletted
        return $"{_rm_type},{_rm_name},{_rm_description},{_rm_points},{_rm_status},{_rm_timesCompletted}";
    }
    
    

    



}