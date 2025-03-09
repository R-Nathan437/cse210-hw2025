using System.Security.Cryptography;

public class Reference
{
 private string _book;
 private string _chapter;
 private string _start;
 private string _end;

 public Reference(string book, string chapter, string start, string end)
 {
    _book = book;
    _chapter = chapter;
    _start = start;
    _end = end;

 }
 public Reference(string book, string chapter, string start)
 {
  _book = book;
  _chapter = chapter;
  _start = start;
  _end = start;
 }
 public string ConvertToString()
 {
    if (_start == _end)
    {
      return string.Format("{0} {1}:{2}", _book, _chapter, _start);
    }
    else
    {
      return string.Format("{0} {1}:{2}-{3}", _book, _chapter, _start, _end);
    }
    
 }
}