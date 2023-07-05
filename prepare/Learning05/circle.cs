
public class Circle : Shape{
    private double _radius;
    public override void SetColor(string color)
    {
        _color = color;
    }
    public override string GetColor()
    {
        return _color;
    }
    public override double GetArea()
    {
        double area = _radius * 3.14;
        return area;
    }
    public Circle(double radius, string color) : base(color){
        _radius = radius;
        _color = color;
    }
}