namespace MiniECommercePlatform;

public class Customer : BaseNamedEntity
{
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
   // public CustomerStatus CustomerStatus { get; set; }
}