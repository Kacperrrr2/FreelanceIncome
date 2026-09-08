namespace FreelanceIncome.Infrastructure.Entities;

public class Order
{
    public Guid Id { get; set; }
    public DateTime OrderDate { get; set; }
    public String Title { get; set; }
    public String Description { get; set; }
    public Decimal  Price { get; set; }
    
    public Guid CurrencyId { get; set; }
    public Currency Currency { get; set; }
}