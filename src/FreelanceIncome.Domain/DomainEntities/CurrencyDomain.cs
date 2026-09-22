namespace FreelanceIncome.Domain.DomainEntities;

public class CurrencyDomain
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Value { get; set; }

    public ICollection<OrderDomain> Orders { get; set; } = new List<OrderDomain>();
}
