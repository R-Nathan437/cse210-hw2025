using System;

class Program
{
    static void Main(string[] args)
    {
        Biking biking = new Biking(40, 20);
        Running running = new Running(30, 1.5);
        Swimming swimming = new Swimming(10, 10); 
        List<Activity> activities = new List<Activity>()
        {
            biking,
            running,
            swimming
        };
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
        
    }
}