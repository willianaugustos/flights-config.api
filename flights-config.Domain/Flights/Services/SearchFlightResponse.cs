using flights_config.Domain.Entities;

namespace flights_config.Domain.Services;

public class SearchFlightsResponse 
{
    public List<Flight> Results {get;set;}
}