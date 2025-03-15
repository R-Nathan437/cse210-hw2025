using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Transactions;

public abstract class Goal
{
    protected string _title;
    public string title
    {
        get{return _title;}
        set{_title = value;}
    }
    protected string _description;
    public string description
    {
        get{return _description;}
        set{_description = value;}
    }
    protected int _goalPoints;
    public int goalPoints
    {
        get{return _goalPoints;}
        set{_goalPoints = value;}
    }
    
    protected bool _status;
    public bool status
    {
        get{return _status;}
        set{_status = value;}
    }
    public Goal()
        {
            title = "";
            description = "";
            goalPoints = 0;
            status = false;
        }
    

    public Goal(string uTitle, string uDescription, int points)
    {
        title = uTitle;
        description = uDescription;
        goalPoints = points;
        status = false;
    }
    public virtual void creatOutline(string Type)
    {
        Console.Write("Goal name: ");
        title = Console.ReadLine();
        Console.Write("Goal description:");
        description = Console.ReadLine();
        Console.Write("Points: ");
        string stringPoints = Console.ReadLine();
        bool incorrect = true;
        while(incorrect)
        {
            if (int.TryParse(stringPoints, out int points))
            {
                goalPoints = points;
                incorrect = false;
            }
            else
            {
                Console.WriteLine("Invalid. Try again.\nPoints:");
                stringPoints = Console.ReadLine();
            }
        }
    }
    public abstract void DisplayGoal();
    public abstract int AddPoints();
    public abstract void RecordGoal();
    public virtual bool IsComplete()
    {
        return status;
    }
    public abstract string Save();
    
}
