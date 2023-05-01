using flights_config.Domain.Repositories;
using MediatR;

namespace flights_config.Domain.Services;

public class SearchFlightsHandler : IRequestHandler<SearchFlightsRequest, SearchFlightsResponse>
{
    private readonly IFlightsRepository _flightsRepository;

    public SearchFlightsHandler(IFlightsRepository flightsRepository)
    {
       _flightsRepository = flightsRepository;
    }

    public async Task<SearchFlightsResponse> Handle(SearchFlightsRequest request, CancellationToken cancellationToken)
    {
        var flightsList = await _flightsRepository.Search(request.IATACodeOrigin, request.IATACodeDestination, cancellationToken);
        var response = new SearchFlightsResponse()
        {
            Results = flightsList
        };
        return response;
    }
}