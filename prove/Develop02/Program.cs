using Develop02;

internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Welcome to the Journal Program!");
        bool isQuestionActive = true;
        Journal j = new Journal();

        while (isQuestionActive) {
            Console.WriteLine("Please select one of the following choices: (#)\n" +
                              "1. Write\n" +
                              "2. Display\n" +
                              "3. Load\n" +
                              "4. Save\n" +
                              "5. Quit");
            Console.Write("What would you like to do? ");
            String option = Console.ReadLine();

            switch (option) {
                case "write" or "1": {
                    if (j.Prompts.Count != 0) {
                        String ranPrompt = null;
                        for (int i = 0; i < j.Prompts.Count; i++) {
                            int randomNum = new Random().Next(1, j.Prompts.Count);
                            ranPrompt = j.Prompts[randomNum - 1];
                        }
                        
                        Console.WriteLine(ranPrompt + " ");
                        Console.Write(">");
                    
                        String response = Console.ReadLine();
                        Entry e = new Entry(ranPrompt, response);
                        j.AddEntry(e);

                        j.Prompts.Remove(ranPrompt);
                    } else {
                        Console.WriteLine("You have ran out prompts to use!\n");
                    }
                    break;
                    
                } case "display" or "2": {
                    j.Display();
                    break;
                    
                } case "load" or "3": {
                    j.LoadJournal();
                    break;
                    
                } case "save" or "4": {
                    j.SaveJournal();
                    break;
                    
                } case "quit" or "5": {
                    isQuestionActive = false;
                    break;
                    
                }
            }
        }
    }
}