namespace flights_config.Domain.Entities;
public class Airport
{
    public String IATACode {get;set;}
    public string Name { get; set; }
    public City City { get; set; }
}