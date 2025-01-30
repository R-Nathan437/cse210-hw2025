public abstract class Shape
{
    protected string _color;
    public string color
    {
        get{return _color;}
        set{_color = value;}
    }

    public Shape(string color) 
    {
        _color = color;
    }
    public abstract double GetArea();
}