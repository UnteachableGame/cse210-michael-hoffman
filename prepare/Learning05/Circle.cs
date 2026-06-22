namespace Learning05;

public class Circle : Shape {
    private double _radius;

    public Circle(string color, double radius) : base(color) {
        _radius = radius;
    }

    public double Radius {
        get => _radius;
        set => _radius = value;
    }

    public string Color1 {
        get => _color;
        set => _color = value;
    }
    
    public override double GetArea() {
        return 0;
    }
}