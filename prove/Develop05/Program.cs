using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();

        Simple s1 = new Simple("goal 2", "second goal (simple)", 23, "simple");
        goalTracker.AddGoal(s1);


        bool _running = true;
        while (_running)
        {
            Console.WriteLine("Record: Type R");
            Console.WriteLine("Create: Type C");
            Console.WriteLine("Display goals: Type D");
            Console.WriteLine("Load: Type L");
            Console.WriteLine("Save: Type S");
            Console.WriteLine("Quit: Type Q");
            string action = Console.ReadLine().ToUpper();
            if (action == "C")
            {
                bool _response = true;
                while (_response)
                {
                    Console.WriteLine("What type of goal would would you like to create:");
                    Console.WriteLine("Checklist: Type C");
                    Console.WriteLine("Eternal: Type E");
                    Console.WriteLine("Simple: Type S");
                    Console.WriteLine("Quit: Type Q");
                    string choice = Console.ReadLine().ToUpper();
                    Console.Clear();
                    if (choice == "C")
                    {
                        Console.WriteLine("Name your goal: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Describe your goal: ");
                        string description = Console.ReadLine();
                        Console.WriteLine("How many points is your goal worth for completing once? ");
                        int points = int.Parse(Console.ReadLine());
                        string type = "checklist";
                        Console.WriteLine("How many times do you need to complete this: ");
                        int steps = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many bonus points do you get for completeing entire goal: ");
                        int bonusPoints = int.Parse(Console.ReadLine()); 
                        Checklist checklist = new Checklist(title, description, points, type, bonusPoints, steps);
                        goalTracker.AddGoal(checklist);
                        _response = false;
                    }
                    else if (choice == "E")
                    {  
                        Console.WriteLine("Name your goal: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Describe your goal: ");
                        string description = Console.ReadLine();
                        Console.WriteLine("How many points is your goal worth? ");
                        int points = int.Parse(Console.ReadLine());
                        string type = "eternal";
                        Eternal eternal = new Eternal(title, description, points, type);
                        goalTracker.AddGoal(eternal);
                        _response = false;
                    }
                    else  if (choice == "S")
                    {
                         Console.WriteLine("Name your goal: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Describe your goal: ");
                        string description = Console.ReadLine();
                        Console.WriteLine("How many points is your goal worth? ");
                        int points = int.Parse(Console.ReadLine());
                        string type = "eternal";
                        Simple simple = new Simple(title, description, points, type);
                        goalTracker.AddGoal(simple);
                        _response = false;
                    }
            
                    else if (choice == "Q")
                    {
                        _response = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input try again.");
                    }
                }
            }
            else if (action == "D")
            {
                goalTracker.DisplayGoalList();
            }
            else if (action == "L")
            {
                Console.WriteLine("What file would you like to load: ");
                string filename = Console.ReadLine();
                goalTracker.LoadGoals(filename);
            }
            else if (action == "S")
            {
                Console.WriteLine("What file would you like to save to: ");
                string filename = Console.ReadLine();
                goalTracker.SaveGoals(filename);
            }
            else  if (action == "R")
            {
                goalTracker.RecordGoal();
            }
            else if (action == "Q")
            {
               _running = false;
            }
            else
            {
               Console.WriteLine("Invalid input try again.");
            }

        }   

    }
}


// Eternal e1 = new Eternal("goal1", "first goal (eternal)", 10, "eternal");
        // goalTracker.AddGoal(e1);
        // goalTracker.DisplayGoalList();
        // e1.RecordGoal();
        // goalTracker.DisplayGoalList();
        // e1.RecordGoal();
        // e1.RecordGoal();
        // goalTracker.DisplayGoalList();
        
        // goalTracker.DisplayGoalList();
        // s1.RecordGoal();
        // goalTracker.DisplayGoalList();
        // Checklist c1 = new Checklist("goal 3", "third goal (checklist)", 5, "checklist", 100, 4);
        // goalTracker.AddGoal(c1);
        // goalTracker.DisplayGoalList();
        // c1.RecordGoal();
        // goalTracker.DisplayGoalList();