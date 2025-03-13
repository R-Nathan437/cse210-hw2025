public class Eternal : Goal
{
    private int _timesCompleted;
    public int timesCompleted
    {
        get{return _timesCompleted;}
        set{_timesCompleted = value;}
    }
    public Eternal(string title, string description, int points) : base(title, description, points)
    {
        _timesCompleted = 0;
    }
    public override void RecordGoal()
    {
        _status = true;
        _timesCompleted++;
    }
    public override int AddPoints()
    {
        return _goalPoints * _timesCompleted;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{_title}\n{_description} || {_goalPoints}points ||  [ ] {_timesCompleted}\n");
    }
    public override string Save()
     {
        return $"{_title},{_description},{_goalPoints},eternal,{_status},{_timesCompleted}";
    }

}