using System.ComponentModel.DataAnnotations;
using System.Net;

public class Comment
{
    private string _author;
    private string _comment;
    public Comment(string author, string comment)
    {
        _author = author;
        _comment = comment;
    }

    public void Display()
    {
        Console.WriteLine($"{_author}|| {_comment}.");
    }
}