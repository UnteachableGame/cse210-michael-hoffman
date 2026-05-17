namespace Develop02;

public class Journal {
    private List<Entry> entries = new ();

    public void addEntry(params Entry[] entries) {
        foreach (Entry entry in entries) {
            this.entries.Add(entry);
        }
    }

    public void saveJournal(String file) {
        using (StreamWriter output = new StreamWriter(file)) {
            foreach (Entry entry in entries) {
                output.WriteLine($"{entry.Date}, {entry.Prompt}, \n{entry.Response}");
            }
        }
    }

    public void loadJournal(String file) {
        entries = new();
        foreach (String lines in File.ReadAllLines(file)) {
            String[] line = lines.Split(",");
            Entry e = new Entry(line[1], line[2], line[0]);
            entries.Add(e);
        }
    }

    public void display() {
        Console.Out.WriteLine($"");
    }
}