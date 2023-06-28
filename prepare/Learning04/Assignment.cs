public class Assignment
{

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;

    }
    protected string _studentName;
    protected string _topic;

    public string GetSummary()
    {
        return ($"{_studentName} - {_topic}");
    }



}

public class MathAssignment : Assignment
{
    private string _textbookPage;
    private string _problem;

    public MathAssignment(string name, string topic, string problems, string textbookPage) : base(name, topic)
    {
        _studentName = name;
        _topic = topic;
        _problem = problems;
        _textbookPage = textbookPage;
    }

    public string GetHomeworkList()
    {
        return ($"{_textbookPage} problems {_problem}");
    }
}

public class WritingAssignment : Assignment
{
    private string _title;
    
    
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return($"{_title} by {_studentName}");
    }

}