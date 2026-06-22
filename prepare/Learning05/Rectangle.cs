namespace Learning05;

public class Rectangle : Shape {
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color) {
        _length = length;
        _width = width;
    }

    public double Length {
        get => _length;
        set => _length = value;
    }

    public double Width {
        get => _width;
        set => _width = value;
    }
    
    public override double GetArea() {
        return 0;
    }
}