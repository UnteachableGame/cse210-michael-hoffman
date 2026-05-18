using Learning03;

internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Hello Learning03 World!");
        
        // Encapsulation

        Fraction f = new Fraction();
        Random ran = new Random();

        for (int i = 0; i < 20; i++) {
            f.Top = ran.Next();
            f.Bottom = ran.Next();
            
            Console.WriteLine($"Fraction 1: string: {f.Top} / {f.Bottom} Number: {f.Top / f.Bottom}");
        }
    }
}