using System;

public class EternalGoal : Goal
{

    List<Goal> _eGoals = new List<Goal>();
    private new bool _isCompleted = false;

    public EternalGoal(string aGoalName, string aGoalDescription) : base(aGoalName,aGoalDescription)
    {

    }
    public override void SetPoints(int aPoints)
    {
        throw new NotImplementedException();
    }
}