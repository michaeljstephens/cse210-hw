class Reception : Event
{
    private string rsvpEmail;

    public Reception
    (string title, 
    string description, 
    string date, 
    string time, 
    Address address, 
    string rsvpEmail)
        : base(title, description, date, time, address)
        
    {
        this.rsvpEmail = rsvpEmail;
    }


    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine("RSVP Email: " + rsvpEmail);
        Console.WriteLine();
    }


    public override void DisplayShortDescription()
    {
        Console.WriteLine("Event Type: Reception");
        Console.WriteLine("Title: " + GetTitle());
        Console.WriteLine("Date: " + GetDate());
        Console.WriteLine();
    }
}
