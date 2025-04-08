using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("1234 Oak Cr", "Rexburg", "ID");
        Address a2 = new Address("4321 Aspen Wy", "Rexy", "ID");
        Address a3 = new Address("2345 Moster Ln", "Lochness", "ID");
        Lecture l1 = new Lecture("Integrals", "Calculus", "18 December 2024", "2:00pm", a1, 35, 70, "Bro.Goodsell");
        Outdoor o1 = new Outdoor("Camping", "backback tent", "7-9 July 2024", "9am", a2, 0,  "Sunny");
        Reception r1 = new Reception("Nathan and Addyson", "Wedding Reception", "20 February 2024", "6:00pm", a3, 10, "example@email.com");
        Console.Clear();
        Console.WriteLine("__________________________________________________");
        l1.DisplayShort();
        l1.DisplayStandard();
        l1.DisplayLecture();
        Console.WriteLine("__________________________________________________");
        o1.DisplayShort();
        o1.DisplayStandard();
        o1.DisplayOutdoor();
        Console.WriteLine("__________________________________________________");
        r1.Rsvp();
        r1.DisplayShort();
        r1.DisplayStandard();
        r1.DisplayReception();
        
    }
}