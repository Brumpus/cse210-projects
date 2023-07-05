public abstract class Shape{
    protected string _color;

    public abstract void SetColor(string color);
    public abstract string GetColor();

    public abstract double GetArea();
    public Shape(string color){
        _color = color;
    }
}






