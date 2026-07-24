using Foundation4;

internal class Program {
    public static List<Activity> activities = new();
    
    private static void Main() {
        Console.Clear();
        
        Activity running1 = new Running(30, 5);
        Activity bicycling1 = new Bicycling(30, 2);
        Activity swimming1 = new Swimming(30, 5);
        
        activities.Add(running1);
        activities.Add(bicycling1);
        activities.Add(swimming1);

        foreach (Activity activity in activities) {
            activity.GetSummary();
            Console.WriteLine();
        }
    }
}