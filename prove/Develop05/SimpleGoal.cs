using System;

public class SimpleGoal : Goal
{
    

    public SimpleGoal(string aGoalName, string aGoalDescription, int aPointValue) : base(aGoalName, aGoalDescription, aPointValue)
    {
        
    }

    public SimpleGoal()
    {

    }

    public override void SetPoints(int aPoints)
    {
        
    }

    public override int GetRepeatTimes()
    {
        throw new NotImplementedException();
    }

    public override int GetCurrentGoalProgress()
    {
        throw new NotImplementedException();
    }

}