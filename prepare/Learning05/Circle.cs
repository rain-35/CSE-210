public class Circle : Shape
{
    private double _rm_radius;

    public Circle(string color, double radius) : base(color)
    {
        _rm_radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _rm_radius * _rm_radius;
    }

}