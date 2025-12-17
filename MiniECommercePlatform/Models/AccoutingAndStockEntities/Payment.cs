namespace MiniECommercePlatform;

public class Payment : BaseEntity
{
    public Guid OrderId { get; set; }
    public Order? Order { get; set; }

    public decimal Amount { get; set; }
    public string? PaymentMethod { get; set; } //e.g., Credit Card, PayPal, etc.
    public PaymentStatus Status { get; set; }
}