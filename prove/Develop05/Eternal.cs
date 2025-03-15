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
        timesCompleted = 0;
    }
    public override void RecordGoal()
    {
        status = true;
        timesCompleted++;
    }
    public override int AddPoints()
    {
        return goalPoints * timesCompleted;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{title}\n{description} || {goalPoints}points ||  [ ] {timesCompleted}\n");
    }
    public override string Save()
     {
        return $"{title},{description},{goalPoints},eternal,{status},{timesCompleted}";
    }

}