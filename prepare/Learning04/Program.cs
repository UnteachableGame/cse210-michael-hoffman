using Learning04;

internal class Program {
    private static void Main(string[] args) {
        Assignment mathAssignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(mathAssignment1.GetSummary());

        Console.WriteLine();

        MathAssignment mathAssignment2 = new MathAssignment("Roberto Rodriguez", "Fractions",
            "7.3", "8-19");
        Console.WriteLine(mathAssignment2.GetSummary());
        Console.WriteLine(mathAssignment2.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History",
            "The Causes of World War II");
        Console.WriteLine(mathAssignment2.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}