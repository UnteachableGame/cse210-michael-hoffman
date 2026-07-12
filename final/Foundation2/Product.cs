namespace Foundation2;

public class Product {
    private String _name;
    private String productID;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity) {
        _name = name;
        productID = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double TotalCost {
        get => PricePerUnit * Quantity;
    }

    public string Name {
        get => _name;
        set => _name = value;
    }

    public string ProductId {
        get => productID;
        set => productID = value;
    }

    public double PricePerUnit {
        get => _pricePerUnit;
        set => _pricePerUnit = value;
    }

    public int Quantity {
        get => _quantity;
        set => _quantity = value;
    }
}