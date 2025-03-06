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
    public Checklist(string title, string description, int points, string type, int bonus, int steps) : base(title, description, points, type)
    {
        _bonusPoints = bonus;
        _steps = steps;
        _progress = 0;
        _bonusStatus = false;
    }
     public override void RecordGoal()
    {
        _progress++;
        if (_progress >= _steps)
        {
            _bonusStatus = true;
        }
        else
        {
            _bonusStatus = false;
        }
        _status = true;
    }
    public override int AddPoints()
    {
        
        if (_bonusStatus)
        {
            return (_goalPoints * _progress) + _bonusPoints;
        }
        else
        {
            return _goalPoints * _progress;
        }
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{_title}\n{_description} || {_goalPoints}points || [{_progress}/{_steps}]\n");
    }
    public override string Save()
    {
        return $"{_title},{_description},{_goalPoints},{_type},{_status},{_bonusPoints},{_bonusStatus},{_steps},{_progress}";
    }

}