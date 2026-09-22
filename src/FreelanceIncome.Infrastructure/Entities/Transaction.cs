namespace FreelanceIncome.Infrastructure.Entities;
public enum Status { Unpaid, InProgress, Paid }

public class Transaction
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Order Order { get; set; }

    public int Amount { get; set; }
    public Status Status { get; set; }
}