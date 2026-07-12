using System.Text;

namespace Foundation2;

public class Order {
    private List<Product> _products;
    private Customer _customer;
    private double _totalPrice;

    public Order(Customer customer) {
        _products = new List<Product>();
        _customer = customer;
    }

    public void DisplayOrderInformation() {
        Console.WriteLine($"Order - {Customer.Name}:\n\n" +
                          $"Products:\n" +
                          $"{DisplayPackingLabelDisplay()}\n" +
                          $"{DisplayShippingLabelDisplay()}\n\n" +
                          $"Total Price: ${TotalPrice:00.00}");
    }

    private String DisplayPackingLabelDisplay() {
        StringBuilder writer = new StringBuilder();
        foreach (Product product in Products) {
            writer.Append($"- {product.Name} ({product.ProductId})\n");
        }

        return writer.ToString();
    }

    private String DisplayShippingLabelDisplay() {
        return $"Name: {Customer.Name} \nAddress: {Customer.Address.GetAddress()}";
    }

    public void CalculateTotalPrice() {
        foreach (Product product in Products) {
            TotalPrice += product.TotalCost;
        }
        if (Customer.IsInUSA) {
            TotalPrice += 5;
        } else {
            TotalPrice += 35;
        }
    }

    public List<Product> Products {
        get => _products;
        set => _products = value;
    }

    public Customer Customer {
        get => _customer;
        set => _customer = value;
    }

    public double TotalPrice {
        get => _totalPrice;
        set => _totalPrice = value;
    }
}