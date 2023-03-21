using System;

abstract public class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _pointValue;
    protected bool _isCompleted = false;

    public Goal()
    {

    }
    public Goal(string aGoalName, string aGoalDescription, int aPointValue)
    {
        _goalName = aGoalName;
        _goalDescription = aGoalDescription;
        _pointValue = aPointValue;
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
            return "X";
        }
    return " ";
    }

    public void isComplete(bool status)
    {
        _isCompleted = status;
    }
    public bool GetisComplete()
    {
        return _isCompleted;
    }

    public virtual int GetPoints()
    {
        return _pointValue;
    }

    virtual public string Display()
    {
        return $"[{GetGoalStatus()}] {GetGoalName()} ({GetGoalDescription()})";
    }

    abstract public int GetRepeatTimes();
    abstract public int GetCurrentGoalProgress();

    abstract public void SetPoints(int aPoints);

}
