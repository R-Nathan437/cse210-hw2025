using System.Dynamic;

public class Checklist : Goal
{
    private int _bonusPoints;
    public int bonusPoints
    {
        get{return _bonusPoints;}
        set{_bonusPoints = value;}
    }
    private bool _bonusStatus;
    public bool bonusStatus
    {
        get{return _bonusStatus;}
        set{_bonusStatus = value;}
    }
    private int _steps;
    public int steps
    {
        get{return _steps;}
        set{_steps = value;}
    }
    private int _progress;
    public int progress
    {
        get{return _progress;}
        set{_progress = value;}
    }
    public Checklist(string title, string description, int points, int bonus, int uSteps) : base(title, description, points)
    {
        bonusPoints = bonus;
        steps = uSteps;
        progress = 0;
        bonusStatus = false;
    }
     public override void RecordGoal()
    {
        progress++;
        if (progress >= steps)
        {
            bonusStatus = true;
        }
        else
        {
            bonusStatus = false;
        }
        status = true;
    }
    public override int AddPoints()
    {
        
        if (bonusStatus)
        {
            return (goalPoints * progress) + bonusPoints;
        }
        else
        {
            return goalPoints * progress;
        }
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{title}\n{description} || {goalPoints}points || [{progress}/{steps}]\n");
    }
    public override string Save()
    {
        return $"{title},{description},{goalPoints}, checklist,{status},{bonusPoints},{bonusStatus},{steps},{progress}";
    }

}