class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();


        Video v1 = new Video("Learn C#", "Jaxson Dart", 300);
        v1.AddComment("Carrie", "Great tutorial!");
        v1.AddComment("Sergio", "Very well put, thanks!");
        v1.AddComment("Bryce", "Do you uhave a course on Python?");
        videos.Add(v1);


        Video v2 = new Video("What are classes in C#", "Jaden McDaniels", 250);
        v2.AddComment("Rudy", "Good explanation.");
        videos.Add(v2);


        Video v3 = new Video("Learn Basic Python in 3 Minutes!", "Mike Budenholzer", 180);
        v3.AddComment("Brad", "Great crash course!");
        v3.AddComment("Chad", "Do you have a part 2?");
        videos.Add(v3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}