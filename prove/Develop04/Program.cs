using System;

class Program
{
    static void Main(string[] args)
    {
        //intro
        Console.WriteLine("Welcome to the Mindfullness Program");
        Console.WriteLine("Let's take a moment together.");
        Console.WriteLine();
        //
        //while menu loop
        bool _response = true;
        while (_response)
        {
            //menu
            Console.WriteLine("What activity would you like to do:");
             Console.WriteLine("Breathing: Type B");
             Console.WriteLine("Listing: Type L");
             Console.WriteLine("Reflecting: Type R");
             Console.WriteLine("Quit: Type Q");
             //
             string choice = Console.ReadLine().ToUpper();
             Console.Clear();
             if (choice == "B") //create and run a breathing activiy
             {
                Breathing breathing = new Breathing();
                breathing.RunBreathing();
                breathing.Animation(5);
             }
             else if (choice == "L") //create and run a Listing activity
             {
                Listing listing = new Listing();
                listing.RunListing();
                listing.Animation(5);
             }
             else  if (choice == "R") //create and run a Reflecting activiy
             {
                Reflecting reflecting = new Reflecting();
                reflecting.RunReflecting();
                reflecting.Animation(5);
             }
             else if (choice == "Q") //exit menu
             {
                _response = false;
             }
            else //user catch for menu
            {
                Console.WriteLine("Invalid input try again.");
            }
        }
    }
}
    
