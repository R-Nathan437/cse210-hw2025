using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hit Enter to start");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture memorizer!");
        Console.WriteLine("Press enter to advance. Type 'quit' to exit");
       Reference scriptureRefrence = new Reference("John","14","15","");
       Scripture scripture = new Scripture("If ye love me, keep my commandments.",scriptureRefrence);
       Verse verse = new Verse(scripture);

       string userInput = "";
       while (userInput.ToLower() != "quit" && verse.HasWordsLeft() == true)
       {
            Console.WriteLine();
            Console.WriteLine(string.Format("{0} {1}", scriptureRefrence.ConvertToString(), verse.ConvertToString()));
            userInput = Console.ReadLine();
            verse.RemoveWords();
       }
       Console.Clear();

    }
}   