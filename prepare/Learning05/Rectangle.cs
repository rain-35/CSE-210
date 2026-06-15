public class Rectangle : Shape
{
    private double _rm_width;
    private double _rm_height;

    public Rectangle(string color, double width, double height) : base(color)
    {
        _rm_width = width;
        _rm_height = height;
    }

    public override double GetArea()
    {
        return _rm_width * _rm_height;
    }

}