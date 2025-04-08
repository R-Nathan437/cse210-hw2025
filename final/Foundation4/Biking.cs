public class Biking : Activity
{
    private double _speed;
    public double speed
    {
        get{return _speed;}
        set{_speed = value;}
    }
    public Biking(double minutes, double speed) : base(minutes)
    {
        _type = "Biking";
        _speed = Math.Round(speed, 2);
    }

    public override double CalculateDistance()
    {
        return Math.Round((speed * 60) / minutes, 2);
    }
    public override double CalculatePace()
    {
        return Math.Round(60 / speed, 2);
    }
    public override void GetSummary()
    {
        Console.WriteLine($"\n{date} {type}({minutes}min): Distance {CalculateDistance()} miles, Speed {speed} mph, Pace {CalculatePace()} mins per mile\n");
    }
}