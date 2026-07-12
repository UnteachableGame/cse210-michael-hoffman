namespace Foundation2;

public class Customer {
    private String _name;
    private Address _address;

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    public bool IsInUSA {
        get => Address.IsInUSA;
    }

    public string Name {
        get => _name;
        set => _name = value;
    }

    public Address Address {
        get => _address;
        set => _address = value;
    }
}