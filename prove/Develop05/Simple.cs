using System.Diagnostics.Contracts;

public class Simple : Goal
{
    public Simple(string name, string description, int points, string type) : base(name, description, points, type)
    {
        
    }
    
    
    public override void RecordGoal()
    {
        _status = true;
    }
    public override int AddPoints()
    {
        return _goalPoints;
    }
    public override void DisplayGoal()
    {
        Console.Write($"{_title}\n{_description} || {_goalPoints}points ||");
        if (IsComplete())
        {
            Console.WriteLine("[X]\n");
        }
        else
        {
            Console.WriteLine("[ ]\n");
        }
    }
    public override string Save()
     {
        return $"{_title},{_description},{_goalPoints},{_type},{_status}";
    }





}