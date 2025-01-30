public class WrittingAssignment : Assignment
{
    private string _title;
    public WrittingAssignment(string studentName, string topic, string title) : base (studentName, topic)
    {
        _title = title;
    }
    public string GetwrittingInfomation()
    {
        string _studentName = GetStudentName();
        return $"{_title}\n Author: {_studentName}";
    } 
}