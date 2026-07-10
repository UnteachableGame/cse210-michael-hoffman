public class Program {
    private static void Main(string[] args) {
        
        // Example 1: Animal
        List<Animal> myAnimals = new List<Animal>();
        myAnimals.Add(new Animal("Liger")); // This is making a new object with the animal class attributes.
        myAnimals.Add(new Dog("Zorro")); // This is a child class of animal.
        myAnimals.Add(new Cat("Oscar")); // This is the second child of animal.
        myAnimals.Add(new Fox("Swiper")); // This is the third child of animal.

        foreach (Animal animal in myAnimals) { // This is a for each loop to 
            animal.MakeNoise(); // This is a called method.
        }
        
        // Example 2: Round Shapes
        List<RoundShape> myShapes = new List<RoundShape>();
        // myShapes.Add(new RoundShape()); Can't instantiate an abstract class.
        myShapes.Add(new Circle(1.0));
        myShapes.Add(new Cylinder(1.0, 0.1));
        myShapes.Add(new Sphere(7.0));

        foreach (RoundShape shape in myShapes) { // This is a for each loop to 
            Console.WriteLine($"{shape.Area()}");
        }
        
    }
}

public class Vehicle {
    protected String _name;
    protected String _make;
    protected String _model;

    public Vehicle(string name, string make, string model) {
        _name = name;
        _make = make;
        _model = model;
    }

    public string Name {
        get => _name;
        set => _name = value;
    }

    public string Make {
        get => _make;
        set => _make = value;
    }

    public string Model {
        get => _model;
        set => _model = value;
    }

    protected void Drive() {
        Console.WriteLine("Driving!");
    }
}

public class Car : Vehicle {
    protected List<String> _truckItems;
    protected int _cupHolders;

    public Car(string name, string make, string model, int cupHolders) : base(name, make, model) {
        _truckItems = new List<string>();
        _cupHolders = cupHolders;
    }

    public List<string> TruckItems {
        get => _truckItems;
        set => _truckItems = value;
    }

    public int CupHolders {
        get => _cupHolders;
        set => _cupHolders = value;
    }
}

// Example 2: Round Shapes w/ Abstraction
public abstract class RoundShape {
    // Abstract method
    public abstract double Area(); // This is an abstract method that has no-body to the method. This will then be used
    // later when using this method.
}

public class Circle : RoundShape {
    protected double _radius;

    public Circle(double radius) {
        _radius = radius;
    }

    public override double Area() {
        return Math.PI * Math.Sqrt(_radius * 2);
    }
}

public class Cylinder : Circle {
    private double _height;

    public Cylinder(double radius, double height) : base(radius) {
        _height = height;
    }

    public override double Area() {
        return 2.0 * Math.PI * Math.Sqrt(_radius) + Math.PI + _radius * _height;
    }
}

public class Sphere : Circle {
    public Sphere(double radius) : base(radius) {
    }

    public override double Area() {
        return 4.0 * Math.PI * Math.Sqrt(_radius * 2);
    }
}

// Example 1: Animals
public class Animal { // This is the parent class of the program.
    protected String _name; // This is a member variable.

    public Animal(string name) { // This is a constructor.
        _name = name; // This initializes the name variable.
    }

    public virtual void MakeNoise() { // This is a method called make noise.
        Console.WriteLine($"{_name} says the same thing that every animal says.");
    }
}

public class Dog : Animal {
    public Dog(string name) : base(name) {
    }

    // Overridden method
    public override void MakeNoise() {
        Console.WriteLine($"{_name} says 'bark.'");
    }
}

public class Cat : Animal {
    public Cat(string name) : base(name) {
    }

    // Overridden method
    public override void MakeNoise() {
        Console.WriteLine($"{_name} says 'meow.'");
    }
}

public class Fox : Animal{
    public Fox(string name) : base(name) {
    }

    // Overridden method
    public override void MakeNoise() {
        Console.WriteLine($"{_name} says 'ring a ding ding dingeriering.'");
    }
}

public abstract class BaseAbility {
    private string _name;
    private int _cooldownSeconds;
    
    protected BaseAbility(string name, int cooldownSeconds) {
        _name = name;
        _cooldownSeconds = cooldownSeconds;
    }
    
    public bool IsOnCooldown(String player) {
        return false;
    }
    
    public abstract void Activate(String player);
    public string Name => _name;
}

public class FireballAbility : BaseAbility {
    public FireballAbility() : base("Fireball", 10) { }
    
    public override void Activate(String player) {
        // player.LaunchFireBall();
    }
}

public class LeapAbility : BaseAbility {
    public LeapAbility() : base("Leap", 5) {
    }
    
    public override void Activate(String player) {
        // player.Velocity = player.Location.Direction * 2;
    }
}

public class AbilityManager {
    private List<BaseAbility> _activeAbilities = new List<BaseAbility>();

    public void RunAll(String player) {
        foreach (BaseAbility ability in _activeAbilities) {
            if (!ability.IsOnCooldown(player)) {
                ability.Activate(player);
            }
        }
    }
}