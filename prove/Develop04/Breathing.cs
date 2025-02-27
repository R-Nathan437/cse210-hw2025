using System.Numerics;

public class Breathing: Activity
{
    /// <summary>
    /// breathing activity should help the user breath by counting their breath with them in real time.
    /// </summary>
    /// constuctor for breathing activity, uses the base activity constructor and sets some of the variables used in the parent class
    public Breathing() : base()
    {
        SetActivityName("Breathing Activity");
        SetActivityDescription("Helps you breathe");
    }
    //since the get userlength function is called after the start message the length has been set, accept if valid, run for a minimum of 10 seconds. Round up to the nearest 10 for all positive integers.
    public void DisplayBreathControl()
    {
        int time;
        if (_length < 10)
        {
            Console.WriteLine("This activity takes a minimun of 10 seconds");
            time = 10;
            SetLength(time);
            Console.WriteLine(time);
        }
        else
        {
            Console.WriteLine("This activity runs in intervals of 10 seconds, rounding to the nearest 10.");
            time = (int)Math.Round(_length / 10.0) * 10; //round to the nearest 10
            Console.WriteLine(time);
            SetLength(time);
        }
        for (int i = 0; i < time/10; i++) //one breath cylce every 10 seconds
        {
            Console.WriteLine("Breathe in for 3 seconds");
            CountUp(3);
            Console.WriteLine("Hold your breath for 4 seconds");
            Hold(4);
            Console.WriteLine("Breathe out for 3 seconds");
            CountDown(3);
        } 
    }
    public void CountUp(int timer)
    {
        for (int i = 1; i <= timer; i++)
        {
            Console.Write(i);//1->3
            Thread.Sleep(1000);//one second wait (the rest of method takes a negligible amount of added time)
            Console.Write("\b\b");//remove last count from screen
        }
    }
    public void CountDown(int timer)
    {
        for (int i = timer; i > 0; i--)
        {
            Console.Write(i);//3->1
            Thread.Sleep(1000);//one second
            Console.Write("\b\b");//remove last count from screen
        }
    }
    public void Hold(int timer)
    {
        for (int i = timer; i > 0; i-- )
        {
            Console.Write(i);//1-4
            Thread.Sleep(1000);//one second
            Console.Write("\b \b");//remove last count from screen
        }
    }

    public void RunBreathing()
    {
        RunStart();//start message, set length and get ready
        DisplayBreathControl();//run the activity
        DisplayEnd();//display the end
    }
}