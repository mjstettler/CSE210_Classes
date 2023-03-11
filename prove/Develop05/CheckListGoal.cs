using System;

public class CheckListGoal : Goal
{
    int _currentGoalProgress = 0;
    int _repeatGoalAmount;


    public CheckListGoal(string aGoalName, string aGoalDescription) : base(aGoalName, aGoalDescription)
    {

    }

    public void SetCurrentGoalProgress(int aProgress)
    {
        _currentGoalProgress = aProgress;
    }

    public void SetRepeatGoalAmount(int aRepeat)
    {
        _repeatGoalAmount = aRepeat;
    }
    public int GetRepeatGoalAmount()
    {
        return _repeatGoalAmount;
    }
    public int GetCurrentGoalProgress()
    {
        return _currentGoalProgress;
    }
    public override void SetPoints(int aPoints)
    {
        throw new NotImplementedException();
    }

    public override string Display()
    {
        return $"[{GetGoalStatus()}] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {GetCurrentGoalProgress()}/{GetRepeatGoalAmount()}";
    }
}