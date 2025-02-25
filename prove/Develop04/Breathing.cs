using System.Numerics;

public class Breathing: Activity
{
    public Breathing() : base()
    {
        SetActivityName("Breathing Activity");
        SetActivityDescription("Helps you breathe");
    }
    public void DisplayBreathControl()
    {
        int time;
        if (Getlength() < 10)
        {
            Console.WriteLine("This activity takes a minimun of 10 seconds");
            time = 10;
            SetLength(time);
            Console.WriteLine(time);
        }
        else
        {
            Console.WriteLine("This activity runs in intervals of 10 seconds, rounding to the nearest 10.");
            time = (int)Math.Round(Getlength() / 10.0) * 10;
            Console.WriteLine(time);
            SetLength(time);
        }
        for (int i = 0; i < time/10; i++)
        {
            Console.WriteLine("Breathe in for 3 seconds");
            CountUp();
            Console.WriteLine("Hold your breath for 4 seconds");
            Hold();
            Console.WriteLine("Breathe out for 3 seconds");
            CountDown();
        } 
    }
    public void CountUp()
    {
        for (int i = 1; i <= 3; i++)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b\b");
        }
    }public void CountDown()
    {
        for (int i = 3; i > 0; i--)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b\b");
        }
    }
    public void Hold()
    {
        for (int i = 4; i > 0; i-- )
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void RunBreathing()
    {
        RunStart();
        DisplayBreathControl();
        DisplayEnd();
    }
}