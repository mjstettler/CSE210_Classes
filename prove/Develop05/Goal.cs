using System;

abstract public class Goal
{
    string _goalName;
    string _goalDescription;
    int _pointValue;
    bool _isCompleted = false;

    abstract public int SetPoints();

}
