public abstract class Goal
{
    protected string _rm_name;
    protected string _rm_description;
    protected int _rm_ponts;
    protected bool _rm_is_complete;

    public Goal(string name, string description, int points)
    {
        _rm_name = name;
        _rm_description = description;
        _rm_ponts = points;

    }

    
}