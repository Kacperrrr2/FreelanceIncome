namespace FreelanceIncome.Domain.DomainEntities;

public class TransactionDomain
{
    public Guid Id { get; set; }
    public int Amount { get; set; }
    public Status Status { get; set; }

    public OrderDomain? Order { get; set; }
}
