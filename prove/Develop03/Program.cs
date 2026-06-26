using Develop03;

internal class Program {
    private static List<Scripture> scriptures = new ();

    private static void Main(string[] args) {
        Console.Clear();
        bool isCorrectResponse = false;
        String beginningResponse = null;
        
        while (!isCorrectResponse) {
            Console.Write("Welcome to the scripture memorizer!\n\n" +
                              "Please choose whether you would like to choose a preloaded scripture or " +
                              "paste in your own scripture with the reference included: \n" +
                              "1. Preloaded Scripture\n" +
                              "2. Custom Scripture\n\n" +
                              "What would you like to choose? ");
            beginningResponse = Console.ReadLine();

            if (beginningResponse == "1" || beginningResponse == "2") {
                isCorrectResponse = true;
            } else {
                Console.WriteLine("\nError! Please choose options 1 or 2. Please try again!");
                Thread.Sleep(1700);
                Console.Clear();
            }
        }

        int chosenScriptureInt = 0;
        Scripture newAddedScripture = null;
        
        switch (beginningResponse) {
            case "1":
                bool isResponseCorrect = false;
                SetScriptures();
                
                while (!isResponseCorrect) {
                    Console.WriteLine("\nHere are the scriptures to choose from:");
                    int indexOfList = 1;
                    foreach (Scripture scripture in scriptures) {
                        Console.Write($"{indexOfList}. \"{scripture.Display()}\"\n");
                        indexOfList++;
                    }

                    Console.Write($"\nWhich scripture would you like to use? (1-{scriptures.Count}): ");
                    String chosenScripture = Console.ReadLine();
                    chosenScriptureInt = int.Parse(chosenScripture);

                    Console.WriteLine(chosenScriptureInt + " :: " + scriptures.Count);
                    Console.WriteLine((chosenScriptureInt > 0) + " :: " + (chosenScriptureInt <= scriptures.Count));

                    if (chosenScriptureInt > 0 && chosenScriptureInt <= scriptures.Count) {
                        isResponseCorrect = true;
                    } else {
                        Console.WriteLine($"\nError! Please choose options 1 through {scriptures.Count}. Please try again!");
                        Thread.Sleep(1700);
                        Console.Clear();
                    }
                }
                break;
            case "2":
                Console.Write("Awesome choice! What is the book of the scripture called? (e.g. Proverbs): ");
                String book = Console.ReadLine();
            
                Console.Write("What is the chapter of the scripture? (e.g. 3): ");
                String chapter = Console.ReadLine();
            
                Console.Write("What is/are the verse(s) of the scripture? (e.g. 4, 4-6): ");
                String verses = Console.ReadLine();
            
                Console.Write("What is the quote of the scripture? (e.g. Trust... thy paths.): ");
                String quote = Console.ReadLine();

                newAddedScripture = new Scripture(
                    new Reference(book, int.Parse(chapter), verses),
                    quote);
                break;
        }
        Console.Clear();
        
        int timesPressedEnter = 0;
        bool isActive = true;

        while (isActive) {
            Console.Clear();
            Scripture proverbs;

            if (beginningResponse == "1") {
                proverbs = scriptures[chosenScriptureInt - 1];
            } else {
                proverbs = newAddedScripture;
            }

            if (proverbs != null) {
                if (timesPressedEnter > 0 && timesPressedEnter < 2) {
                    // targets 1 specifically.
                    proverbs.HasFirstPassed = true;
                }
                if (timesPressedEnter < 2 || timesPressedEnter >= 3) {
                    proverbs.HideWords();
                }

                Console.WriteLine(proverbs.Display());
            } else {
                break;
            }
            
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            String response = Console.ReadLine();
            
            if (response == "quit") {
                isActive = false;
            } else {
                timesPressedEnter++;
            }
        }
    }
    
    public static void SetScriptures() {
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, "5-6"),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all " +
            "thy ways acknowledge him, and he shall direct thy paths."));
    }
}