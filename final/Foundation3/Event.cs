class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public Event
    (string title, 
    string description, 
    string date, 
    string time, 
    Address address)

    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }


    public virtual void DisplayStandardDetails()
    {
        Console.WriteLine(title);
        Console.WriteLine(description);
        Console.WriteLine("Date: " + date + ", Time: " + time);
        Console.WriteLine("Location: " + address.GetFullAddress());
        Console.WriteLine();
    }


    public virtual void DisplayFullDetails()
    {
        DisplayStandardDetails();
    }


    public virtual void DisplayShortDescription()
    {
        Console.WriteLine("Event Type: General");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Date: " + date);
        Console.WriteLine();
    }


    public string GetTitle()
    {
        return title;
    }


    public string GetDate()
    {
        return date;
    }
}



