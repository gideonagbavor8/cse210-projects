// Author: Gideon Komla Agbavor

// Purpose: a program that displays the full scripture and then hides a few words at a time until the complete scripture is hidden.

// Showing Creativity and Exceeding Requirements
// // Load multiple scriptures from a file and select one at random
// Read scriptures from a file and create Scripture objects
// // Hide only one word at a time in th


using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        var scriptures = new List<Scripture>();
        foreach (var line in File.ReadAllLines(filePath))
        {
            var parts = line.Split('|');
            if (parts.Length >= 5) // Ensure there are at least 5 parts
            {
                var reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), string.IsNullOrEmpty(parts[3]) ? (int?)null : int.Parse(parts[3]));
                var text = parts[4];
                scriptures.Add(new Scripture(reference, text));
            }
            else
            {
                Console.WriteLine($"Skipping invalid line: {line}");
            }
        }
        return scriptures;
    }

    static void Main()
    {
        var scriptures = LoadScripturesFromFile("scriptures.txt");
        var scripture = scriptures[new Random().Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine($"{scripture.Reference.GetDisplayText()}\n{scripture.GetDisplayText()}");
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit: ");
            var userInput = Console.ReadLine();
            if (userInput?.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWord(); // Hide only one word at a time
        }

        Console.Clear();
        Console.WriteLine($"{scripture.Reference.GetDisplayText()}\n{scripture.GetDisplayText()}");
        Console.WriteLine("All words are hidden. Program ended.");
    }
}
