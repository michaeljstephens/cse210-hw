class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing";
        description = "This activity will help you relax by guiding you through slow breathing.";
    }


    public override void Run()
    {
        Start();
        int timeLeft = duration;
        while (timeLeft > 0)
        {
            Console.WriteLine("Breathe in...");
            Pause(3);
            Console.WriteLine("Breathe out...");
            Pause(3);
            timeLeft -= 6;
        }
        End();
    }
}