using Foundation2;

internal class Program {
    private static List<Order> orders = new();
    
    private static void Main() {
        Console.Clear();
        
        Order order1 = new Order(new Customer("Bill", new Address("123 Oak Tree St", "Apple City", "GA", "USA")));
        List<Product> products1 = order1.Products;
        products1.Add(new Product("Apples", "123", 0.99f, 4));
        products1.Add(new Product("Oranges", "234", 1.25f, 3));
        products1.Add(new Product("Bananas", "345", 0.66f, 6));
        orders.Add(order1);
        
        Order order2 = new Order(new Customer("Robby", new Address("987 Cherry Tree St", "Green Rise", "RT", "INDIA")));
        List<Product> products2 = order2.Products;
        products2.Add(new Product("Grapes", "135", 2.99f, 2));
        products2.Add(new Product("Pickles", "246", 1.95f, 10));
        products2.Add(new Product("Tomatoes", "357", 0.40f, 4));
        orders.Add(order2);

        foreach (Order order in orders) {
            order.CalculateTotalPrice();
            order.DisplayOrderInformation();
            Console.WriteLine("\n---\n");
        }
    }
}