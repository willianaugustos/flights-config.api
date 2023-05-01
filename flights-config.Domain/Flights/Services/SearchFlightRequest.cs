using MediatR;

namespace flights_config.Domain.Services;

public class SearchFlightsRequest : IRequest<SearchFlightsResponse>
{
    public SearchFlightsRequest(string iATACodeOrigin, string iATACodeDestination)
    {
        this.IATACodeOrigin = iATACodeOrigin;
        this.IATACodeDestination = iATACodeDestination;
    }    
    
    public string IATACodeOrigin { get; set; }
    public string IATACodeDestination { get; set; }
}