using System.Reflection;
using flights_config.Data.Mappings;
using flights_config.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Flights.Data.Contexts;

public class FlightsContext : DbContext
{
    public DbSet<Airport> Airports { get; set; }
    
    public FlightsContext(DbContextOptions<FlightsContext> options) : base(options)
    {
       
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=flights;Username=postgres;Password=mystrongpass");

    public Task<IDbContextTransaction> BeginTransactionAsync()
    => Database.BeginTransactionAsync();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //modelBuilder.ApplyConfiguration(new AirportMapping());
   
        base.OnModelCreating(modelBuilder);
    }
}
    
