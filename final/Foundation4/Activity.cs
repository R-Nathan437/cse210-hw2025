using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

public abstract class Activity
{
    protected string _type;
    public string type
    {
        get{return _type;}
        set{_type = value;}
    }
    protected double _minutes;
    public double minutes
    {
        get{return _minutes;}
        set{_minutes = value;}
    }
    protected string _date;
    public string date
    {
        get{return _date;}
        set{_date = value;}
    }
    // private DateTime _timeStart;
    // public DateTime TimeStart
    // {
    //     get{return _timeStart;}
    //     set{_timeStart = value;}
    // }
    //  private DateTime _timeEnd;
    // public DateTime TimeEnd
    // {
    //     get{return _timeEnd;}
    //     set{_timeEnd = value;}
    // }
    public Activity(double minutes)
    {
        _minutes = minutes;
        _date = DateTime.Now.ToShortDateString();
    }
    // public void StartTimer()
    // {
    //     TimeStart = DateTime.Now;
    // }
    // public void EndTimer()
    // {
    //     TimeEnd = DateTime.Now;
    // }
    public virtual double CalculateDistance()
    {
        int speed = 0;
        return (speed * 60 )/minutes;
    }
    public virtual double CalculateSpeed()
    {
        double distance = 0;
        return (distance/minutes) * 60;
    }
    public abstract double CalculatePace();

    public virtual void GetSummary()
    {
        Console.WriteLine($"\n{date} {type}({minutes}min): Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace {CalculatePace()} mins per mile\n");
    }
}