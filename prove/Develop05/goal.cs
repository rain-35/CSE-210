public abstract class Goal
{
    protected string _rm_type;
    protected string _rm_name;
    protected string _rm_description;
    protected int _rm_points;
    protected bool _rm_status;
    protected int _rm_timesCompletted;
    protected string _rm_checkbox;

    public Goal(string name, string description, int points)
    {
        _rm_name = name;
        _rm_description = description;
        _rm_points = points;
        _rm_status = false;
        _rm_checkbox = "[ ]";

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
    
    

    



}