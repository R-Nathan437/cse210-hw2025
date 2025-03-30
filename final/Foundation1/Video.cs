
using System.ComponentModel.DataAnnotations;
using System.Net;

public class Video
{
    private string _title;
    private string _length;
    private string _author;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string length, string author)
    {
        _title = title;
        _length = length;
        _author = author;
    }
    public void AddComment(string author, string text)
    {
        Comment _comment = new Comment(author, text);
        _comments.Add(_comment);
    }

    public void Display()
    {
        Console.WriteLine($"{_title}\n\n{_length}\n{_author}");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

}