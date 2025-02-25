public class Activity
{
   public string _activityName;
    
    protected string _endMessege;
    protected string _description;
    protected int _length;
    
    public Activity()
    {
      _length = 0;
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
   public void  SetActivityDescription(string description)   
    {
        _description = description;
    }
    public void SetLength(int time)
    {
      _length = time;
    }
    public void UserSetLength()
    {
      Console.Write("How many seconds will this run for? ");
      string stringLength = Console.ReadLine();
      bool looping = true;
      while (looping)
      {
         if (int.TryParse(stringLength, out int runTime))
         {
            _length = runTime;
            looping = false;
         }
         else
         {
            Console.WriteLine("invalid input");
            Console.Write("How many seconds will this run for?");
            stringLength = Console.ReadLine();
         }
      }
    }
    public int Getlength()
    {
      return _length;
    }
   public void DisplayStartMessage()
   {
      Console.Clear();
      Console.WriteLine($"{_activityName}\n{_description}");
   }
   public void DisplayEnd()
   {
      Console.WriteLine($"{_activityName} ran for {_length} seconds.");
      Console.WriteLine(_endMessege);
   }
   public void DisplayReady()
   {
      Console.WriteLine("Get Ready");
      Animation(3);
      Console.WriteLine("Start:");
      Thread.Sleep(250);
      Console.Clear();
   }

    public void Animation(int timer)
    {
      DateTime time = DateTime.Now;
      DateTime timeEnd = time.AddSeconds(timer);
      List<string> animationString = new List<string>()
      {
         "/",
         "|",
         "\\",
         "-"
      };
      int i = 0;
      while (DateTime.Now < timeEnd)
      {
         string s = animationString[i];
         Console.Write(s);
         Thread.Sleep(100);
         Console.Write("\b\b");

         i++;
         if (i >= 4)
         {
            i = 0;
         }
      }
   }
   public void RunStart()
   {
      DisplayStartMessage();
      UserSetLength();
      DisplayReady();
   }
}