internal class Program {
    private static void Main(string[] args) {
        Console.Write("What was your grade percentage? ");
        String gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        bool passedClass = false;
        String letter = null;
        if (grade >= 90) {
            letter = "A";
            passedClass = true;
        } else if (grade >= 80) {
            letter = "B";
            passedClass = true;
        } else if (grade >= 70) {
            letter = "C";
            passedClass = true;
        } else if (grade >= 60) {
            letter = "D";
        } else if (grade < 60) {
            letter = "F";
        }

        String plusOrMinus;
        int[] gradeDigits = grade.ToString()
            .Select(digit => int.Parse(digit.ToString()))
            .ToArray();
        int secondDigit = gradeDigits[1];
        
        if (secondDigit >= 7) {
            plusOrMinus = "+";
        } else if (secondDigit < 3) {
            plusOrMinus = "-";
        } else {
            plusOrMinus = "";
        }

        if (passedClass) {
            Console.WriteLine($"Your grade is a {plusOrMinus}{letter} and have passed the class! Great job!");
        } else {
            Console.WriteLine($"Your grade is a {plusOrMinus}{letter} and haven't passed the class! You can do this next time! You got this!");
        }
    }
}