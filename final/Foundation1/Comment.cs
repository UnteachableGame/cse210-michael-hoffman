namespace Foundation1;

public class Comment {
    private String _name;
    private String _text;

    public Comment(string name, string text) {
        _name = name;
        _text = text;
    }

    public void Display() {
        Console.Write($"- {Name}\n    * {Text}\n");
    }

    public string Name {
        get => _name;
        set => _name = value;
    }

    public string Text {
        get => _text;
        set => _text = value;
    }
}