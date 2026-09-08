namespace FreelanceIncome.Infrastructure.Entities;

public class Currency
{
    public Guid Id { get; set; }
    public String Name { get; set; }
    public Decimal Value { get; set; }

    public Order Order { get; set; }
}