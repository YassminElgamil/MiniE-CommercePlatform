namespace MiniECommercePlatform;

public class Order_Product: BaseEntity //snapshot of product at the time of order
{
    public Guid OrderId { get; set; }

    public Guid ProductId { get; set; }
    public Product? Product { get; set; }

    public string? ProductName { get; set; }
    public decimal PriceAtTime { get; set; }
    public int Quantity { get; set; }
}
