namespace flights_config.Domain.Entities;
public class Airport : EntityBase
{
    public String IATACode {get; init;}
    public string Name { get; init; }
    public City City { get; init; }
    public ECountries Country {get; init;}
}