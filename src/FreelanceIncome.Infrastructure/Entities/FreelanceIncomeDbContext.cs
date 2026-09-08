using Microsoft.EntityFrameworkCore;

namespace FreelanceIncome.Infrastructure.Entities;

public class FreelanceIncomeDbContext :DbContext
{
    public FreelanceIncomeDbContext(DbContextOptions<FreelanceIncomeDbContext> options): base(options)
    {
        
    }
    
   public DbSet<Order> Orders { get; set; }
   public DbSet<Currency> Currencies { get; set; }
   public DbSet<Client> Clients { get; set; }
   public DbSet<Transaction> Transactions { get; set; }
   public DbSet<User> Users { get; set; }

    
}