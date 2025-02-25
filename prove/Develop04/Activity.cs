public class Activity
{
    /// <summary>
    /// an activity should have a start and end message, getters and setters for attributes and an animation function
    /// </summary>
    //attributes
   public string _activityName;
    
    protected string _endMessege;
    protected string _description;
    protected int _length;
    
    public Activity()//constuctor for all activities
    {
      _length = 0;
    }
    //set variables
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
    //user set
    //ask for the amount and make sure the input is valid, if valid set lenght
    public void UserSetLength()
    {
      Console.Write("How many seconds will this run for? ");
      string stringLength = Console.ReadLine();
      bool looping = true;
      while (looping)
      {
         if (int.TryParse(stringLength, out int runTime))
         {
            SetLength(runTime);
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
    //getter
    public int Getlength()
    {
      return _length;
    }
    //display start format: name, description
   public void DisplayStartMessage()
   {
      Console.Clear();
      Console.WriteLine($"{_activityName}\n{_description}");
   }
   //display end format: name ran for () seconds
   public void DisplayEnd()
   {
      Console.WriteLine($"{_activityName} ran for {_length} seconds.");
      Console.WriteLine(_endMessege);
   }
   //ready message [req: animation]
   public void DisplayReady()
   {
      Console.WriteLine("Get Ready");
      Animation(3);
      Console.WriteLine("Start:");
      Thread.Sleep(250);//wait
      Console.Clear();//clear the console
   }
    //animation for console
    public void Animation(int timer)
    {
      DateTime time = DateTime.Now;
      DateTime timeEnd = time.AddSeconds(timer);
      List<string> animationString = new List<string>()//these characters in sequence look like a spinning line
      {
         "/",
         "|",
         "\\",
         "-"
      };
      int i = 0;
      while (DateTime.Now < timeEnd)//check the time every time you write and delete the char for the animation
      {
         string s = animationString[i];
         Console.Write(s);//write char
         Thread.Sleep(100);
         Console.Write("\b\b");//delete last char

         i++;
         if (i >= 4)//if finsihed go back to the beggining of the characters
         {
            i = 0;
         }
      }
   }
   //simplify activity process
   public void RunStart()
   {
      DisplayStartMessage();
      UserSetLength();
      DisplayReady();
   }
}