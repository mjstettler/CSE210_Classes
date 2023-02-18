using System;

class WritingAssignments : Assignments
{
    private string _assignmentTitle;


public WritingAssignments(string aStudentName, string aTopic, string aAssignmentTitle) : base(aStudentName, aTopic)
{
    _assignmentTitle = aAssignmentTitle;
}
    public string GetWritingInfo()
    {
        string studentName = GetStudentName();
        return $"{_assignmentTitle} by {studentName}";
    }
}