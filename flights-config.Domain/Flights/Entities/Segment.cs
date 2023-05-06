namespace flights_config.Domain.Entities;

public class Segment
{
    /* public virtual Flight LinkedFlight {get;set;}
     public int SegmentNumber {get;set;}
     public Airline Airline {get;set;}
     public String FlightNumber {get;set;}
     public Airport Origin {get;set;}
     public Airport Destination {get;set;}
     public ECabinClasses CabinClass {get;set;}
     public DateOnly DepartureDate {get;set;}
     public string DepartureTime {get;set;}
     public string ArrivalTime {get;set;}
     public string ArrivalDateRelative {get;set;}
     public string Duration {get;set;}
     public string AdditionalInfo {get;set;}*/

    public Guid FlightId { get; set; }
    public int SegmentNumber { get; set; }
    public Guid Airline { get; set; }
    public string FlightNumber { get; set; }
    public string AirportOrigin { get; set; }
    public string AirportDestination { get; set; }
    public string CabinClass { get; set; }
    public DateTime DepartureDate { get; set; }
    public string DepartureTime { get; set; }
    public string ArrivalTime { get; set; }
    public string ArrivalDateRelative { get; set; }
    public string Duration { get; set; }
    public string AdditionalInfo { get; set; }
    public virtual Flight Flight { get; set; }
}