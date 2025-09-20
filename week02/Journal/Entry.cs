using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public override string ToString()
    {
        return $"Prompt: {_prompt}\nResponse: {_response}\nDate: {_date}";
    }
}