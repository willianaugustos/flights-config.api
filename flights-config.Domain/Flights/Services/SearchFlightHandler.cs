using MediatR;

namespace flights_config.Domain.Services;

public class SearchFlightsHandler : IRequestHandler<SearchFlightsRequest>
{
    Task<Unit> IRequestHandler<SearchFlightsRequest, Unit>.Handle(SearchFlightsRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}