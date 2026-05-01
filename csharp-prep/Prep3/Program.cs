using System.Xml;

internal class Program {
    private static void Main(string[] args) {
        // Console.WriteLine();
        // Console.WriteLine();
        // Console.WriteLine();

        int magicNum;
        int guessNum;

        int count;
        bool isGameActive = true;

        while (isGameActive) {
            Console.Write("What is the magic number? ");
            String magicNumber = Console.ReadLine();

            count = 0;
            do {
                Console.Write("What is your guess? ");
                String guess = Console.ReadLine();

                magicNum = int.Parse(magicNumber);
                guessNum = int.Parse(guess);
            
                if (guessNum < magicNum) {
                    Console.WriteLine("Higher");
                } else if (guessNum > magicNum) {
                    Console.WriteLine("Lower");
                }

                Console.WriteLine();
                count++;
            } while (guessNum != magicNum);

            if (guessNum == magicNum) {
                Console.WriteLine($"You guessed it in {count} tries!");
            }

            Console.Write("Would you like to play again? [yes/no]: ");
            String answer = Console.ReadLine();

            if (answer == "no") isGameActive = false;
        }
        Console.WriteLine("Thank you for playing! Have a good day!");
    }
}