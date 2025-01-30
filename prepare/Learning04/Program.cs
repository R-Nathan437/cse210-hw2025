using System;

class Program
{
    static void Main(string[] args)
    {
       Assignment assignmentOne = new Assignment("Sam Cumberbatch", "Algebra");
       Console.WriteLine(assignmentOne.GetSummary());
       MathAssignment assignmentTwo = new MathAssignment("Abigail Gadot", "Deriviatives", "4.4", "2-38");
       Console.WriteLine(assignmentTwo.GetStudentName());
       Console.WriteLine(assignmentTwo.GetHomeworkList());
       WrittingAssignment assignmentThree = new WrittingAssignment("Harry Potter", "Herbology", "Mandrakes");
       Console.WriteLine(assignmentThree.GetSummary());
       Console.WriteLine(assignmentThree.GetwrittingInfomation());
    }
}