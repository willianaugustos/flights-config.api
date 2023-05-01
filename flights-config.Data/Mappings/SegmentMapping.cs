using System.Reflection.Emit;
using flights_config.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace flights_config.Data.Mappings;

public class SegmentMapping : IEntityTypeConfiguration<Segment>
{
    public void Configure(EntityTypeBuilder<Segment> builder)
    {
        builder.ToTable("FlightSegments");
        builder.HasKey(f => new { f.FlightId, f.SegmentNumber });

        
      
        //builder.ToTable("Flights");
        // builder.Property(p=>p.Id).HasColumnName("FlightId");
        // builder.Property(p=>p.Origin).HasColumnName("AirportOrigin");
        // //builder.Property(p=>p.Destination).HasColumnName("AirportDestination");
        // builder.Property(p=>p.Stops).HasColumnName("Stops");
        // builder.Property(p=>p.Price).HasColumnName("Price");
        // builder.Property(p=>p.PriceType).HasColumnName("PriceType");
        // builder.Property(p=>p.CurrencySign).HasColumnName("CurrencySign");
        // builder.Property(p=>p.SearchDate).HasColumnName("SearchDate");
        // builder.Property(p=>p.SourceUrl).HasColumnName("SourceUrl");
        // builder.Property(p=>p.SourceName).HasColumnName("SourceName");
        // builder.Property(p=>p.LoyaltyProgram).HasColumnName("LoyaltyProgram");
        // builder.Property(p=>p.DepartureDate).HasColumnName("DepartureDate");
        // builder.Property(p=>p.DepartureTime).HasColumnName("DepartureTime");
        // builder.Property(p=>p.ArrivalTime).HasColumnName("ArrivalTime");
        // builder.Property(p=>p.ArrivalDateRelative).HasColumnName("ArrivalDateRelative");
        // builder.Property(p=>p.Duration).HasColumnName("Duration");
        // builder.Property(p=>p.AdditionalInfo).HasColumnName("AdditionalInfo");
        // //builder.Property(p=>p.LinkedFlightId).HasColumnName("LinkedFlightId");
        //builder.HasOne(p=>p.Origin);
    }
}