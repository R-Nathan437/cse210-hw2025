public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    public List<Goal> goals
    {
        get{return _goals;}
        set{_goals = value;}
    }
    protected int _collectedPoints = 0;
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }
    public void DisplayGoalList()
    {
        Console.Clear();
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{index}. ");
            goal.DisplayGoal();
            index++;
        }
        DisplayPoints();
    }
    public int CountPoints()
    {
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                _collectedPoints += goal.AddPoints();
            }
        }
        return _collectedPoints;
    }
    public void DisplayPoints()
    {
        CountPoints();
        Console.WriteLine($"Total: {_collectedPoints} points\n");
        _collectedPoints = 0;
    }
    public void RecordGoal()
    {
        Console.WriteLine("Which goal would you like:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{index}. ");
            goal.DisplayGoal();
            index++;
        }
        Console.WriteLine("type the associated number");
        string userInput = Console.ReadLine();
        bool looping = true;
        while (looping)
            if (int.TryParse(userInput, out int userGoal))
            {
                int userIndex = userGoal - 1;
                looping = false;
                _goals[userIndex].RecordGoal();
            }
            else
            {
                Console.WriteLine("invalid input");
                Console.WriteLine("type the associated number");
                userInput = Console.ReadLine();
            }
        

    }
    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.Save());
            }
        }

    }
    public void LoadGoals(string loadfilename)
    {
        List<Goal> loadGoals = new List<Goal>();
        if (loadfilename.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(loadfilename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string type = parts[3].ToLower();
                if (type == "simple")
                {
                    string title = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool status = bool.Parse(parts[4]);
                    Simple simple = new Simple(title, description, points, type);
                    simple.status = status;
                    loadGoals.Add(simple);
                }
                else if (type == "eternal")
                {
                    string title = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool status = bool.Parse(parts[4]);
                    int timesCompleted = int.Parse(parts[5]);
                    Eternal eternal = new Eternal(title, description, points, type);
                    eternal.status = status;
                    eternal.timesCompleted = timesCompleted;
                    loadGoals.Add(eternal);
                }
                else if (type == "checklist")
                {
                    string title = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool status = bool.Parse(parts[4]);
                    int bonusPoints = int.Parse(parts[5]);
                    bool bonusStatus = bool.Parse(parts[6]);
                    int steps = int.Parse(parts[7]);
                    int progress = int.Parse(parts[8]);
                    Checklist checklist = new Checklist(title, description, points, type, bonusPoints, steps);
                    checklist.status = status;
                    checklist.bonusStatus = bonusStatus;
                    checklist.progress = progress;
                    loadGoals.Add(checklist);
                }
            }
        }
        DisplayGoalList();
    }

}