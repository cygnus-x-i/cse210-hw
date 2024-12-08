class Order
{
    public List<Product> Products;
    public Customer Customer;

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal productTotal = 0;
        foreach (var product in Products)
        {
            productTotal += product.TotalCost();
        }

        decimal shippingCost = Customer.LivesInUSA() ? 5 : 35;
        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.Address.FullAddress()}";
    }
}