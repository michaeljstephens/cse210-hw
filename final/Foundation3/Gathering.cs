class Gathering : Event
{
    private string weather;

    public Gathering
    (string title, 
    string description, 
    string date, 
    string time, 
    Address address, 
    string weather)
        : base(title, description, date, time, address)
    {
        this.weather = weather;
    }


    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine("Weather Forecast: " + weather);
        Console.WriteLine();
    }


    public override void DisplayShortDescription()
    {
        Console.WriteLine("Event Type: Outdoor Gathering");
        Console.WriteLine("Title: " + GetTitle());
        Console.WriteLine("Date: " + GetDate());
        Console.WriteLine();
    }
}