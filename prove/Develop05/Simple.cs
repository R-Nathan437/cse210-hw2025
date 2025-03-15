using System.Diagnostics.Contracts;

public class Simple : Goal
{
    public Simple(string name, string description, int points) : base(name, description, points)
    {
        
    }
    
    
    public override void RecordGoal()
    {
        status = true;
    }
    public override int AddPoints()
    {
        return goalPoints;
    }
    public override void DisplayGoal()
    {
        Console.Write($"{title}\n{description} || {goalPoints}points ||");
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
        return $"{title},{description},{goalPoints}, simple, {status}";
    }

}