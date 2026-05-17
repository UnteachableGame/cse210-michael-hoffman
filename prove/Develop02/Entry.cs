namespace Develop02;

public class Entry {
    private String prompt;
    private String response;
    private String date;

    public Entry(string prompt, string response, string date) {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    public Entry(String prompt, String response) {
        this.prompt = prompt;
        this.response = response;
        date = DateTime.Now.ToShortDateString();
    }

    public string Prompt {
        get => prompt;
        set => prompt = value;
    }

    public string Response {
        get => response;
        set => response = value;
    }

    public string Date {
        get => date;
        set => date = value;
    }

    public void display() {
        Console.Out.WriteLine($"{date} {prompt} \n{response}");
    }
}