public class Square : Shape{
    private double _side;

    public override void SetColor(string color){
        _color = color;
    }
    public override string GetColor(){
        return _color;
    }
    public override double GetArea(){
        double area = _side * _side;
        return area;
    }

    public Square(double side, string color) : base(color){
        _color = color;
        _side = side;
    }
}