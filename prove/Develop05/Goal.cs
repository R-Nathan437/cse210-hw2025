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
        set{description = value;}
    }
    protected int _goalPoints;
    public int goalPoints
    {
        get{return _goalPoints;}
        set{_goalPoints = value;}
    }
    protected string _type;
    public string type
    {
        get{return _type;}
        set{_type = value;}
    }
    protected bool _status;
    public bool status
    {
        get{return _status;}
        set{_status = value;}
    }
    public Goal()
        {
            _title = "";
            _description = "";
            _goalPoints = 0;
            _type = "";
             _status = false;
        }
    

    public Goal(string title, string description, int points, string type)
    {
        _title = title;
        _description = description;
        _goalPoints = points;
        _type = type;
        _status = false;
    }
    public virtual void creatOutline(string Type)
    {
        Console.Write("Goal name: ");
        _title = Console.ReadLine();
        Console.Write("Goal description:");
        _description = Console.ReadLine();
        Console.Write("Points: ");
        string stringPoints = (Console.ReadLine());
        bool incorrect = true;
        while(incorrect)
        {
            if (int.TryParse(stringPoints, out int points))
            {
                _goalPoints = points;
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
        return _status;
    }
    public abstract string Save();
    
}
