using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        bool response = true;
        while (response)
        {
             Console.WriteLine("Add Entry: Type A");
             Console.WriteLine("Save Entry: Type S");
             Console.WriteLine("Load Entry: Type L");
             Console.WriteLine("Display Entry: D");
             Console.WriteLine("Clear File: C");
             Console.WriteLine("Quit: Type Q");
             
             string choice = Console.ReadLine().ToUpper();
             if (choice == "A")
             {
                _journal.AddEntry();
                Console.WriteLine();
             }
             else if (choice == "S")
             {
                Console.Write("Enter File Name: ");
                string filename = Console.ReadLine();
                _journal.Save(filename);
             }
             else if (choice == "L")
             {
                Console.Write("Enter File Name:");
                string loadFilename = Console.ReadLine();
                _journal.Load(loadFilename);
             }
             else if (choice == "D")
             {
               _journal.Display();
             }
             else if (choice == "C")
             {
                Console.Write("Enter File Name: ");
                string clearFilename = Console.ReadLine();
                _journal.Clear(clearFilename);
             }
             else if (choice == "Q")
             {
                response = false;
             }
            else
            {
                Console.WriteLine("Invalid input try again.");
            }
        }
    }
}



///display menu loop
///add to journal
///quit