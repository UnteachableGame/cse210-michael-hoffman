internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<Double> numbers = new ();

        bool isGameActive = true;

        while (isGameActive) {
            Console.Write("Enter number: ");
            String answer = Console.ReadLine();
            int number = int.Parse(answer);
            
            if (number != 0) {
                numbers.Add(number);
            } else {
                isGameActive = false;
            }
        }

        int sumTotal = 0;
        double average;
        int largeNumber = 0;

        foreach (int number in numbers) {
            sumTotal += number;
            
            if (number > largeNumber) {
                largeNumber = number;
            }
        }
        Console.WriteLine($"The sum is: {sumTotal}");

        average = sumTotal / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        Console.WriteLine($"The largest number is: {largeNumber}");
        int smallNumber = largeNumber;
        
        foreach (int number in numbers) {
            if (number < smallNumber && smallNumber > 0) {
                smallNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallNumber}");
        
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers) {
            Console.WriteLine(number);
        }

    }
}