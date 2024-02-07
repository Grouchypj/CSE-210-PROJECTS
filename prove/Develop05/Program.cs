using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Sample usage
        List<Goal> goals = new List<Goal>
        {
            new SimpleGoal("Run a marathon", 1000),
            new EternalGoal("Read scriptures", 100),
            new ChecklistGoal("Attend the temple", 50, 10)
        };

        foreach (Goal goal in goals)
        {
            goal.RecordEvent();
            goal.DisplayProgress();
        }
    }
}
