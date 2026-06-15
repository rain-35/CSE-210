public abstract class Shape
{
    private string _rm_color;

    public Shape(string color)
    {
        _rm_color = color;
    }

    public string GetColor()
    {
        return _rm_color;
    }

    public void SetColor(string color)
    {
        _rm_color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }

}