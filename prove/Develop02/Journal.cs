namespace Develop02;

public class Journal {
    private List<Entry> _entries = new();
    private List<String> _prompts = new();
    
    public Journal() {
        Prompts.Add("How would you spend a week-long vacation if you had the time with no money limit?");
        Prompts.Add("How would respond to someone who is being aggravating?");
        Prompts.Add("How were you able to share you charity today? Who was it with?");
        Prompts.Add("What was the best miracle that happened to you this week?");
        Prompts.Add("Do you like Apple or Samsung products? Why?");
    }

    public void AddEntry(params Entry[] entries) {
        foreach (Entry entry in entries) {
            Entries.Add(entry);
        }
    }

    public void SaveJournal() {
        Console.WriteLine("What is the filename?");
        String fileName = Console.ReadLine();

        fileName = "../../../" + fileName;

        bool isValidFileName = false;
        while (!isValidFileName) {
            try {
                if (Entries.Count != 0) {
                    using StreamWriter writer = new StreamWriter(fileName);
                    foreach (Entry entry in Entries) {
                        writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                    }
                    writer.Close();
                    Console.WriteLine("File has saved successfully!");
                    
                } else {
                    Console.WriteLine("There are no entries to save into the text file!");
                }
                isValidFileName = true;
                
            } catch (NullReferenceException) {
                Console.WriteLine("You didn't enter in a valid file name. Please try again!");
                throw;
            }
        }
    }

    public void LoadJournal() {
        Console.WriteLine("What is the filename?");
        String fileName = Console.ReadLine();
        
        fileName = "../../../" + fileName;

        Entries = new (); 
        bool isValidFileName = false;

        while (!isValidFileName) {
            try {
                foreach (String lines in File.ReadAllLines(fileName)) {
                    String[] line = lines.Split(",");
                    Entry e = new Entry(line[1], line[2], line[0]);
                    Entries.Add(e);
                }
                Console.WriteLine("File has loaded successfully!");

                isValidFileName = true;
            } catch (NullReferenceException) {
                Console.WriteLine("You didn't enter in a valid file name. Please try again!");
                throw;
            }
        }
    }

    public void Display() {
        if (Entries.Count != 0) {
            foreach (Entry entry in Entries) {
                Console.Out.WriteLine($"Date: {entry.Date} - Prompt: {entry.Prompt}\n{entry.Response}\n");
            }
        } else {
            Console.WriteLine("There are no entries submitted to the journal currently.");
        }
    }

    public List<Entry> Entries {
        get => _entries;
        set => _entries = value;
    }

    public List<string> Prompts {
        get => _prompts;
        set => _prompts = value;
    }
}