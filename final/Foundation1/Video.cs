class Video
{
    public string title;
    public string author;
    public int length;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
    }


    public void AddComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
    }


    public int CountComments()
    {
        return comments.Count;
    }


    public void Display()
    {
        Console.WriteLine("Title: " + title + ", Author: " + author + ", Length: " + length + " seconds");
        Console.WriteLine("Comments (" + CountComments() + "):");
        foreach (Comment comment in comments)
        {
            Console.WriteLine("- " + comment.name + ": " + comment.text);
        }
        Console.WriteLine();
    }
}