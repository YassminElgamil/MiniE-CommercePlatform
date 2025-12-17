namespace MiniECommercePlatform;

public class Inventory : BaseEntity
{
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }

    public decimal AvailableQuantity { get; set; }
    public decimal ReservedQuantity { get; set; }
}