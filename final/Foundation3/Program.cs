using Foundation3;

internal class Program {
    public static List<Event> events = new ();
    
    private static void Main() {
        Console.Clear();
        
        Event lecture1 = new Lecture("Physics", "The things of the earth that has math to it.", 
            new Address("123 Oak Street", "Rocky", "YT", "USA"), "Billy Bob", 32);
        Event reception1 = new Receptions("Marriage of Sally and Bill", "The reception for the marriage of Sally and Bill.", 
            new Address("234 Cherry Ave", "Freedom", "DS", "USA"), true, true);
        Event outdoorGathering1 = new OutdoorGatherings("Gills Family Reunion", "The Gills are having a family reunion.", 
            new Address("345 Maple Cir", "Union", "ET", "USA"), "Sunny");
        
        events.Add(lecture1);
        events.Add(reception1);
        events.Add(outdoorGathering1);
        
        foreach (Event eventS in events) {
            Console.WriteLine("Standard Details:\n" + 
                              eventS.DisplayStandardDetails() + "\n");
            Console.WriteLine("Full Details:\n" + 
                              eventS.DisplayFullDetails() + "\n");
            Console.WriteLine("Short Details:\n" + 
                              eventS.DisplayShortDetails() + "\n");
        }
    }
}