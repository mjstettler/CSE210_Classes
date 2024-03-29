using System;

public class CheckListGoal : Goal
{
    List<Goal> _ckGoals = new List<Goal>();
    int _currentGoalProgress = 0;
    int _timesRepeated;
    int _completionPoints;


    public CheckListGoal(string aGoalName, string aGoalDescription, int aPointValue, int aRepeat, int aExtraPoints) : base(aGoalName, aGoalDescription, aPointValue)
    {
        _timesRepeated = aRepeat;
        _completionPoints = aExtraPoints;
    }

    public void SetCurrentGoalProgress(int aProgress)
    {
        _currentGoalProgress = aProgress;
    }

    public void SetTimesGoalRepeated(int aRepeat)
    {
        _timesRepeated = aRepeat;
    }
    public override int GetRepeatTimes()
    {
        return _timesRepeated;
    }
    public override int GetCurrentGoalProgress()
    {
        return _currentGoalProgress;
    }
    public override void SetPoints(int aPoints)
    {
        _pointValue = aPoints;
    }
    public override int GetPoints()
    {
        int points = 0;
        _currentGoalProgress++;

        if (_currentGoalProgress < _timesRepeated)
        {
            points = base.GetPoints();
        }
        else if (_currentGoalProgress == _timesRepeated)
        {
            points = _completionPoints;
            isComplete(true);
        }
        return points;
    } 

    public void SetCompletionPoints(int aPoints)
    {
        _completionPoints = aPoints;
    }

    public int GetCompletionPoints()
    {
        return _completionPoints;
    }

    public override string Display()
    {
        return $"[{GetGoalStatus()}] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {GetCurrentGoalProgress()}/{GetRepeatTimes()}";
    }

}