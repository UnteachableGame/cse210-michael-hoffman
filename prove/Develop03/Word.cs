namespace Develop03;

public class Word {
    private String _text;

    public Word(string text) {
        _text = text;
    }

    public void Hide() {
        foreach (char c in Text) {
            Text = Text.Replace(c, '_');
        }
    }

    public string Text {
        get => _text;
        set => _text = value;
    }
}