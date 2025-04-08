public class Running : Activity
{
    private double _distance;
    public double distance
    {
        get{return _distance;}
        set{_distance = value;}
    }
    public Running(double minutes, double distance) : base(minutes)
    {
        _type = "Running";
        _distance = Math.Round(distance, 2);
    }

    public override double CalculateSpeed()
    {
        return Math.Round(60 / CalculatePace());
    }
    public override double CalculatePace()
    {
        return Math.Round(minutes/distance, 2);
    }
    public override void GetSummary()
    {
        Console.WriteLine($"\n{date} {type} ({minutes}min): Distance {distance} miles, Speed {CalculateSpeed()} mph, Pace {CalculatePace()} mins per mile\n");
    }
}