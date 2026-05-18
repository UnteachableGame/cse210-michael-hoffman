using Develop02;

internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Hello Develop02 World!");
        
        // 1. write
        // 2. display
        // 3. save
        // 4. load
        // 5. 
        
        /* Classes w/ variables & methods
         Journal
            entries: List<Entry>
            
            addEntry()
            displayEntries()
         Entry
            date
            prompt
            response
            
            display()
         */

        bool isQuestionActive = true;
        String file = "info.txt";
        Journal j = new Journal();

        while (isQuestionActive) {
            Console.WriteLine("Please select one of the following choices: \n" +
                              "1. Write\n" +
                              "2. Display\n" +
                              "3. Load\n" +
                              "4. Save\n" +
                              "5. Quit");
            String option = Console.ReadLine();

            switch (option) {
                case "write": {
                    Entry e = new Entry("prompt", "response");
                    j.addEntry(e);
                    break;
                } case "display": {
                    j.display();
                    break;
                } case "load": {
                    j.loadJournal(file);
                    break;
                } case "save": {
                    j.saveJournal(file);
                    break;
                } case "quit": {
                    isQuestionActive = false;
                    break;
                }
            }
        }
    }
}