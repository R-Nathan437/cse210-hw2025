using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfullness Program");
        Console.WriteLine("Let's take a moment together.");
        Console.WriteLine();
        bool _response = true;
        while (_response)
        {
            Console.WriteLine("What activity would you like to do:");
             Console.WriteLine("Breathing: Type B");
             Console.WriteLine("Listing: Type L");
             Console.WriteLine("Reflecting: Type R");
             Console.WriteLine("Quit: Type Q");
             string choice = Console.ReadLine().ToUpper();
             Console.Clear();
             if (choice == "B")
             {
                Breathing breathing = new Breathing();
                breathing.RunBreathing();
                breathing.Animation(5);
             }
             else if (choice == "L")
             {
                Listing listing = new Listing();
                listing.RunListing();
                listing.Animation(5);
             }
             else  if (choice == "R")
             {
                Reflecting reflecting = new Reflecting();
                reflecting.RunReflecting();
                reflecting.Animation(5);
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
}
    
