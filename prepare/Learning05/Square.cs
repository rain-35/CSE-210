public class Square : Shape
{
    private double _rm_side;

    public Square(string color, double side) : base(color)
    {
        _rm_side = side;
    }

    public override double GetArea()
    {
        return _rm_side * _rm_side;
    }

}