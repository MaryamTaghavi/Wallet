using Microsoft.EntityFrameworkCore;
using Wallet.Shared.Persistence.Entities;

namespace Wallet.Shared.Persistence; 

public class WalletDbContext(DbContextOptions<WalletDbContext> dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<Currency> Currencies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyMaker.ApplicationAssembly) ;
    }
}
