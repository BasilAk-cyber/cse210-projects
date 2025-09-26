using System;

public class House
{
    public string _owner;
    public List<Blind> _blinds = new List<Blind>();

    public void AddBlind(Blind blind)
    {
        _blinds.Add(blind);
    }

    public void DisplayBlinds()
    {
        foreach (Blind blind in _blinds)
        {
            blind.Display();
        }
    }
}

