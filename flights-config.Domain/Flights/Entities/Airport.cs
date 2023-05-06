using System.ComponentModel.DataAnnotations.Schema;

namespace flights_config.Domain.Entities;
public class Airport : EntityBase
{
    public String IATACode {get; init;}
    public string Name { get; init; }
    public string City { get; init; }
    public string State {get;init;}
    public string Country {get; init;}
    [NotMapped]
    public virtual List<Flight> OriginFlights {get;set;}
    [NotMapped]
    public virtual List<Flight> DestinationFlights{get;set;}
}