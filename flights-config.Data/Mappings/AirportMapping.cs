using flights_config.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace flights_config.Data.Mappings;

public class AirportMapping : IEntityTypeConfiguration<Airport>
{
    public void Configure(EntityTypeBuilder<Airport> builder)
    {
        Console.WriteLine("Mapping entities...");
       
        builder.ToTable("Airports");
        builder.HasKey(k=>k.IATACode);
        builder.Property(p=>p.City);
        builder.Property(p=>p.Country);
        builder.Property(p=>p.Id).HasColumnName("AirportId");
        builder.Property(p=>p.Name);
        builder.Property(p=>p.State);
    }
}