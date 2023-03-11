using System;

public class SimpleGoal : Goal
{
    List<SimpleGoal> sgoals = new List<SimpleGoal>();

public SimpleGoal(string aGoalName, string aGoalDescription) : base(aGoalName, aGoalDescription)
{

}

    public override void SetPoints(int aPoints)
    {
        
    }
}