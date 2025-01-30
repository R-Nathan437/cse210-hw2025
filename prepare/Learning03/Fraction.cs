public class Fraction
{

    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }
    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }
    public string GeString()
    {
        string text = $"{_topNumber}/{_bottomNumber}";
        return text;
    }
    public double GetDecimal()
    {
        return (double)_topNumber / (double)_bottomNumber;
        
    }
}