using System;

public class EternalGoal : Goal
{

    private bool _isCompleted = false;

    public EternalGoal(string aGoalName, string aGoalDescription) : base(aGoalName,aGoalDescription)
    {

    }
    public override void SetPoints(int aPoints)
    {
        throw new NotImplementedException();
    }
    
    
    
}