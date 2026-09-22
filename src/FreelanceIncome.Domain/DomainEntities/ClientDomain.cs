namespace FreelanceIncome.Domain.DomainEntities;

public class ClientDomain
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public UserDomain? User { get; set; }
    public ICollection<OrderDomain> Orders { get; set; } = new List<OrderDomain>();
}
