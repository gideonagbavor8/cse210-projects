// Author: Gideon Komla Agbavor
// For this assignment you will write a program to help people record the events of their day by supplying prompts and then saving their responses along with the question and the date to a file.

/*
 * Enhancements to exceed requirements:
 * 1. Added mood rating (1-5) and tags to each journal entry.
 * 2. Implemented saving and loading of journal entries in CSV format 
 *    with proper handling of commas and quotation marks.
 * 3. Added functionality to save and load entries in JSON format 
 *    using Newtonsoft.Json library for better data management.
 * 4. Provided tips for users to help them overcome writer's block.
 */



using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to CSV file (journal.csv)");
            Console.WriteLine("4. Load journal from CSV file (journal.csv)");
            Console.WriteLine("5. Save journal to JSON file");
            Console.WriteLine("6. Load journal from JSON file");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Display a random prompt to help users
                    string prompt = journal.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    Console.Write("Rate your mood (1-5): ");
                    int mood = int.Parse(Console.ReadLine());
                    Console.Write("Enter tags (comma-separated): ");
                    string tags = Console.ReadLine();
                    journal.AddEntry(response, mood, tags);
                    Console.WriteLine("Entry added.");
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    // Save to the default filename "journal.csv"
                    journal.SaveToCsv("journal.csv");
                    Console.WriteLine("Journal saved to journal.csv.");
                    break;
                case "4":
                    // Console.Write("Enter filename to load (CSV): ");
                    // Load from the default filename "journal.csv"
                    journal.LoadFromCsv("journal.csv");
                    Console.WriteLine("Journal loaded from journal.csv.");
                    break;
                case "5":
                    Console.Write("Enter filename to save (JSON): ");
                    string saveJsonFilename = Console.ReadLine();
                    journal.SaveToJson(saveJsonFilename);
                    Console.WriteLine("Journal saved to JSON.");
                    break;
                case "6":
                    Console.Write("Enter filename to load (JSON): ");
                    string loadJsonFilename = Console.ReadLine();
                    journal.LoadFromJson(loadJsonFilename);
                    Console.WriteLine("Journal loaded from JSON.");
                    break;
                case "7":
                    running = false;
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
