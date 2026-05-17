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

        while (isQuestionActive) {
            Console.WriteLine("Please select one of the following choices: \n" +
                              "1. Write\n" +
                              "2. Display\n" +
                              "3. Load\n" +
                              "4. Save\n" +
                              "5. Quit");
            String option = Console.ReadLine();

            switch (option) {
                case "write": 
                    
                case "display":
                
                case "load":
                
                case "save":
                
                case "quit":
                    isQuestionActive = false;
                    break;
            }
        }

        String file = "info.txt";
        
        Entry e1 = new Entry("prompt", "response");
        e1.display();
        Entry e2 = new Entry("prompt", "response");
        e2.display();
        Entry e3 = new Entry("prompt", "response");
        e3.display();
        
        Journal j = new Journal();
        j.addEntry(e1, e2, e3);
        j.saveJournal(file);
        j.display();
        j.loadJournal(file);
        

    }
}