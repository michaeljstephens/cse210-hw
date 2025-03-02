class ReflectingActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you helped someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you were kind to someone."
    };


    private string[] questions = {
        "Why was this important to you?",
        "How did you feel after?",
        "What did you learn from it?"
    };


    public ReflectingActivity()
    {
        name = "Reflection";
        description = "This activity will help you reflect on times you've shown strength.";
    }


    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        Pause(5);

        int timeLeft = duration;
        while (timeLeft > 0)
        {
            Console.WriteLine(questions[rand.Next(questions.Length)]);
            Pause(5);
            timeLeft -= 5;
        }
        End();
    }
}