using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Event> events = new List<Event>
        {
            new Lecture(
                "Python Lecture",
                "Learn from instructor about python",
                "March 20",
                "3:00 PM",
                new Address("525 S Center St", "Rexburg", "ID", "83440"),
                "Dr. Smith",
                111),

            new Reception(
                "Wedding of LeBron and Savannah",
                "The James Family's celebration of Matrimony",
                "July 20",
                "6:00 PM",
                new Address("175 Valley River Dr", "Rexburg", "ID", "83440"),
                "rsvp@google.com"),

            new Gathering(
                "Pickleball Pickup",
                "Play pickleball, meet new people, and enjoy the spring weather",
                "April 15",
                "7:00 AM",
                new Address("5th West & 3rd Noth", "Rexburg", "ID", "83440"),
                "Sunny")
        };


        foreach (Event ev in events)
        {
            ev.DisplayStandardDetails();
            ev.DisplayFullDetails();
            ev.DisplayShortDescription();


            Console.WriteLine("------------------------");
        }
    }
}

