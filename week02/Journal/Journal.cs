// Author: Gideon Komla Agbavor
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private static readonly string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }

    public void AddEntry(string response, int mood, string tags)
    {
        var prompt = GetRandomPrompt();
        var date = DateTime.Now.ToString("yyyy-MM-dd");
        var entry = new Entry(prompt, response, date, mood, tags);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToCsv(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"\"{entry.Date}\",\"{entry.Prompt}\",\"{entry.Response}\",\"{entry.Mood}\",\"{entry.Tags}\"");
            }
        }
    }

    public void LoadFromCsv(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');
                if (parts.Length == 5)
                {
                    int mood = int.Parse(parts[3].Trim('"'));
                    string tags = parts[4].Trim('"');
                    entries.Add(new Entry(parts[1].Trim('"'), parts[2].Trim('"'), parts[0].Trim('"'), mood, tags));
                }
            }
        }
    }

    public void SaveToJson(string filename)
    {
        string json = JsonConvert.SerializeObject(entries, Formatting.Indented);
        File.WriteAllText(filename, json);
    }

    public void LoadFromJson(string filename)
    {
        entries.Clear();
        string json = File.ReadAllText(filename);
        entries = JsonConvert.DeserializeObject<List<Entry>>(json);
    }
}
