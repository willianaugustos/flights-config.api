namespace flights_config.Domain.Entities;

public class Flight
{
    public Airport? Origin {get;set;}
    public Airport? Destination {get;set;}
    public int Stops {get;set;}
    public IList<Segment> Segments {get;set;} = new List<Segment>();
    public Decimal Price {get;set;}
    public EPriceType PriceType {get;set;}
    public String? CurrencySign {get;set;}
}