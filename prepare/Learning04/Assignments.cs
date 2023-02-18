using System;

class Assignments
{
    private string _studentName;
    private string _topic;
    
    public Assignments(string aStudentName, string aTopic)
    {
        _studentName = aStudentName;
        _topic = aTopic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}