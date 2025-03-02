using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    protected string name;
    protected string description;
    protected int duration;


    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {name} Activity...");
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }


    public void End()
    {
        Console.WriteLine($"Good job! You completed the {name} activity for {duration} seconds.");
        Pause(3);
    }


    public void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }


    public virtual void Run() { }


    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            if (choice == "1")
                new BreathingActivity().Run();
            else if (choice == "2")
                new ReflectingActivity().Run();
            else if (choice == "3")
                new ListingActivity().Run();
            else if (choice == "4")
                break;
        }
    }
}