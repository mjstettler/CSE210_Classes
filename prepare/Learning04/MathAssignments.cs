using System;

class MathAssignments : Assignments
{
    private double _textBookSection;
    private string _problems;

    public MathAssignments(string aStudentName, string aTopic, double aTextBookSection, string aProblems) : base(aStudentName, aTopic)
    {
        _textBookSection = aTextBookSection;
        _problems = aProblems;
    }
    public string GetHomeWorkList()
    {
        
        return $"Section {_textBookSection} Problems {_problems}";
    }
}