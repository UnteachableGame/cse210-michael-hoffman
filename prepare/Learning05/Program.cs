using Learning05;

internal class Program {
    private static void Main(string[] args) {

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Shape("red"));
        shapes.Add(new Square("orange", 3.0f));
        shapes.Add(new Rectangle("blue", 4.0f, 5.0f));
        shapes.Add(new Circle("purple", 4.0f));

        Square sqrt = new Square("Red", 3.0f);
        Console.WriteLine(sqrt.GetArea());
        Console.WriteLine(sqrt.Color);
    }
}