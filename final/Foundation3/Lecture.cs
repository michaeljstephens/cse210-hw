class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture
    (string title, 
    string description, 
    string date, 
    string time, 
    Address address, 
    string speaker, 
    int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }


    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine("Speaker: " + speaker);
        Console.WriteLine("Capacity: " + capacity);
        Console.WriteLine();
    }


    public override void DisplayShortDescription()
    {
        Console.WriteLine("Event Type: Lecture");
        Console.WriteLine("Title: " + GetTitle());
        Console.WriteLine("Date: " + GetDate());
        Console.WriteLine();
    }
}

