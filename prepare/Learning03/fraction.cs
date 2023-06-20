public class Fraction 
{
    private int _top = 0;
    private int _bottom = 0;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
    }
    
    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    public int GetTopNumber()
    {
        int topNumber = _top;
        return topNumber;
    }
    public int GetBottomNumber()
    {
        int bottomNumber = _bottom;
        return bottomNumber;
    }
    public void SetTopNumber(int number)
    {
        _top = number;
    }
    public void SetBottomNumber(int number)
    {
        _bottom = number;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double GetDecimalValue()
    {
        double top = Convert.ToDouble(_top);
        double bottom = Convert.ToDouble(_bottom);
        double fractionDecimal = (top / bottom);
        return fractionDecimal;
    }
}