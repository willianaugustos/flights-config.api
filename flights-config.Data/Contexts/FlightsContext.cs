using System.Collections;
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
    public DbSet<Airline> Airlines { get; set; }
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Segment> FlightSegments { get; set; }
    private readonly IConfiguration config;

    public FlightsContext(DbContextOptions<FlightsContext> options, IConfiguration _config) : base(options)
    {
        config = _config;
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(config.GetConnectionString("FlightsDB"));

    public Task<IDbContextTransaction> BeginTransactionAsync()
    => Database.BeginTransactionAsync();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
}
    
