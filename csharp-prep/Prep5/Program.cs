internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        
        DisplayWelcome();
        String name = PromptUserName();
        int number = PromptUserNumber();
        int year = PromptUserBirthYear();
        SquareNumber(name, number);
        DisplayResult(name, year);
    }

    public static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }

    public static String PromptUserName() {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    public static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        String favNum = Console.ReadLine();
        return int.Parse(favNum);
    }

    public static int PromptUserBirthYear() {
        Console.Write("Please enter the year you were born: ");
        String yearString = Console.ReadLine();
        return int.Parse(yearString);
    }

    public static void SquareNumber(String name, int num) {
        Console.WriteLine($"{name}, the square of your number is {Math.Pow(num, 2)}");
    }

    public static void DisplayResult(String name, int year) {
        Console.WriteLine($"{name}, you will turn {2026 - year - 1} this year.");
    }
}