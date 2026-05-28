namespace Develop02;

public class Entry {
    private String _prompt;
    private String _response;
    private String _date;

    public Entry(string prompt, string response, string date) {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public Entry(String prompt, String response) {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToShortDateString();
    }

    public string Prompt {
        get => _prompt;
        set => _prompt = value;
    }

    public string Response {
        get => _response;
        set => _response = value;
    }

    public string Date {
        get => _date;
        set => _date = value;
    }

    public void display() {
        Console.Out.WriteLine($"{_date} {_prompt} \n{_response}");
    }
}