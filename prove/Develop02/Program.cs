using System;
using System.Collections.Generic;
using System.IO;


class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToShortDateString();
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}


class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "What were the main one or two things that you did today?",
        "What was the hardest part of my day?",
        "What am I grateful for in my life today?",
        "Rate the day today out of 5.",
        "What area could I improve in based on today?"
    };


    public void WriteEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        entries.Add(new Entry(prompt, response));
    }



    public void Display()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }



    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }



    public void Load(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (var line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 3)
                {
                    entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}


class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        while (true)

        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)

            {
                case "1":
                    journal.WriteEntry();
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    journal.Save(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    journal.Load(Console.ReadLine());
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid, try again.");
                    break;
            }
        }
    }
}

