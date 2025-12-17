namespace MiniECommercePlatform;

public class Order : BaseEntity
{
    public string? OrderCode { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public List<Order_Product>? OrderItems { get; set; }
}