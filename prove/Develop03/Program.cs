using System;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        Scripture verse = new Scripture(reference, text);

        while (!verse.IsFullyHid())
        {
            Console.Clear();
            verse.Display();
            Console.WriteLine("\nPress enter to hide words or type 'exit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            verse.HideWords(3);
        }

        Console.Clear();
        verse.Display();
    }
}