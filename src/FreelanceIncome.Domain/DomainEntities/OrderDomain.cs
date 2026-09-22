namespace FreelanceIncome.Domain.DomainEntities;

public class OrderDomain
{
    public Guid Id { get; set; }
    public DateTime OrderDate { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public ClientDomain? Client { get; set; }
    public CurrencyDomain? Currency { get; set; }
    public ICollection<TransactionDomain> Transactions { get; set; } = new List<TransactionDomain>();
}
