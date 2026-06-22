namespace Learning05;

public class Shape {
    protected String _color;

    public Shape(string color) {
        _color = color;
    }

    public string Color {
        get => _color;
        set => _color = value;
    }

    public virtual double GetArea() {
        return 0;
    }
}