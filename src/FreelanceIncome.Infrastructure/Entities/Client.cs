namespace FreelanceIncome.Infrastructure.Entities;

public class Client
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}