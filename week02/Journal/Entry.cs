// Author: Gideon Komla Agbavor

using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public int Mood { get; set; } // Mood rating from 1 to 5
    public string Tags { get; set; } // Comma-separated tags

    public Entry(string prompt, string response, string date, int mood, string tags)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
        Mood = mood;
        Tags = tags;
    }

    public override string ToString()
    {
        return $"{Date} | {Prompt} | {Response} | Mood: {Mood} | Tags: {Tags}";
    }
}
