namespace MiniECommercePlatform;

public class Product : BaseNamedEntity
{
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? Code { get; set; }
    public ProductStatus Status { get; set; }
}
