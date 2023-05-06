using System.ComponentModel.DataAnnotations.Schema;

namespace flights_config.Domain.Entities;

public class Flight
{
    public Guid FlightId { get; set; }
    public string AirportOrigin { get; set; }
    public string AirportDestination { get; set; }
    public Guid AirlineId { get; set; }
    public int Stops { get; set; }
    public decimal Price { get; set; }
    public int PriceType { get; set; }
    public string CurrencySign { get; set; }
    public DateTime SearchDate { get; set; }
    public string SourceUrl { get; set; }
    public string SourceName { get; set; }
    public string LoyaltyProgram { get; set; }
    public DateTime DepartureDate { get; set; }
    public string DepartureTime { get; set; }
    public string ArrivalTime { get; set; }
    public string ArrivalDateRelative { get; set; }
    public string Duration { get; set; }
    public string AdditionalInfo { get; set; }
    public Guid? LinkedFlightId { get; set; }
    public virtual Airline Airline { get; set; }
    public virtual ICollection<Segment> FlightSegments { get; set; } = new List<Segment>();

   

  /*  [NotMapped]
    public virtual Airport Origin {get;set;}
    [NotMapped]
    public virtual Airport Destination {get;set;}
    

    [NotMapped]
    public int Stops {get;set;}
    [NotMapped]
    public virtual IList<Segment> Segments {get;set;} = new List<Segment>();
    [NotMapped]
    public Decimal Price {get;set;}
    [NotMapped]
    public EPriceType PriceType {get;set;}
    [NotMapped]
    public string CurrencySign {get;set;}
    [NotMapped]
    public DateTime SearchDate {get;set;}
    [NotMapped]
    public string SourceUrl {get;set;}
    [NotMapped]
    public string SourceName {get;set;}
    [NotMapped]
    public string LoyaltyProgram {get;set;}
    [NotMapped]
    public DateOnly DepartureDate {get;set;}
    [NotMapped]
    public string DepartureTime {get;set;}
    [NotMapped]
    public string ArrivalTime {get;set;}
    [NotMapped]
    public string ArrivalDateRelative {get;set;}
    [NotMapped]
    public string AdditionalInfo {get;set;}
    [NotMapped]
    public string Duration {get;set;}
    [NotMapped]
    public virtual Flight LinkedFlightId {get;set;}*/
}