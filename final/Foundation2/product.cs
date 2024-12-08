class Product
{
    public string Name;
    public string ProductId;
    public decimal PricePerUnit;
    public int Quantity;

    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public decimal TotalCost()
    {
        return PricePerUnit * Quantity;
    }
}