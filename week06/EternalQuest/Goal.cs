using System;
using System.Collections.Generic;
using System.IO;

/* 
 * CREATIVITY AND EXCEEDING REQUIREMENTS:
 * Level System: Users progress through levels as they earn points. Every 1000 points earns a new level
 * with an associated title (Beginner → Apprentice → Journeyman → Expert → Master → Legend).
 * The program displays current level, title, and progress toward the next level.
 * When users level up, they receive a special congratulations message with ASCII art.
 */

 public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName() => _name;

    // Abstract methods - must be implemented by derived classes (polymorphism)
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    public virtual int GetPoints()
    {
        return _points;
    }

    public virtual string GetDisplayString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_description})";
    }
}