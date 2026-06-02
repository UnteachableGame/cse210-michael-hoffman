internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Hello Sandbox World!");

        Animal bear = new Animal();
        bear._type = "Bear";
        bear._name = "Mark";
        bear.Display();
    }
}

public class Animal {
    public String _type = "";
    public String _name = "";

    public void Display() {
        Console.WriteLine($"The type of this animal is {_type} and their name is {_name}!");
    }
}