class ListingActivity : Activity
{
    private string[] prompts = {
        "List people you appreciate.",
        "List things you are good at.",
        "List moments that made you happy."
    };


    public ListingActivity()
    {
        name = "Listing";
        description = "This activity helps you list positive things in your life.";
    }


    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        Pause(5);

        List<string> responses = new List<string>();
        int timeLeft = duration;
        while (timeLeft > 0)
        {
            Console.Write("Enter something: ");
            responses.Add(Console.ReadLine());
            timeLeft -= 2;
        }

        Console.WriteLine($"You listed {responses.Count} items!");
        End();
    }
}