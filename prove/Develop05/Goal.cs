using System;

abstract public class Goal
{
    string _goalName;
    string _goalDescription;
    int _pointValue;
    bool _isCompleted = false;

    public Goal(string aGoalName, string aGoalDescription)
    {
        _goalName = aGoalName;
        _goalDescription = aGoalDescription;

    }

    public void SetGoalName(string aGoalName)
    {
        _goalName = aGoalName;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalDescription(string aGoalDescription)
    {
        _goalDescription = aGoalDescription;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public string GetGoalStatus()
    {
        if (_isCompleted)
        {
            return "x";
        }
    return " ";
    }

    abstract public int SetPoints();

}
