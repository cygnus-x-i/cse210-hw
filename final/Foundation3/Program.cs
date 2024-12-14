class Program
{
    static void Main(string[] args)
    {
        // Create Addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak Ave", "Austin", "TX", "USA");

        // Create Events
        Lecture lecture = new Lecture(
            "Tech Talk 2024",
            "A deep dive into AI advancements",
            "12/10/2024",
            "10:00 AM",
            address1,
            "Alice Smith",
            100
        );

        Reception reception = new Reception(
            "Networking Gala",
            "An evening to meet professionals in your industry.",
            "12/15/2024",
            "7:00 PM",
            address2,
            "rsvp@galaevent.com"
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Community Picnic",
            "A fun day in the park with family activities.",
            "12/20/2024",
            "11:00 AM",
            address3,
            "Sunny with a high of 75°F"
        );

        // Display Marketing Messages
        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine(ev.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.FullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.ShortDescription());
            Console.WriteLine(new string('-', 40)); // Divider
        }
    }
}
