namespace flights_config.Domain.Entities;

public class Segment
{
    public Airline? Airline {get;set;}
    public String? Number {get;set;}
    public Airport? Origin {get;set;}
    public Airport? Destination {get;set;}
    public ECabinClasses CabinClass {get;set;}
    public String? LoyaltyProgram {get;set;}
}