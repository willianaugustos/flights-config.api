using Flights.Config.Domain.Airport.Queries;
using flights_config.Domain.Repositories;
using MediatR;


namespace Flights.Config.Domain.Airport.Queries;

public class GetAirportByIATACodeHandler : IRequestHandler<GetAirportByIATACodeRequest, flights_config.Domain.Entities.Airport>
{
    private readonly IAirportsRepository _airportRepository;

    public GetAirportByIATACodeHandler(IAirportsRepository airportRepository)
    {
        _airportRepository = airportRepository;
    }

    public async Task<flights_config.Domain.Entities.Airport> Handle(GetAirportByIATACodeRequest request, CancellationToken cancellationToken)
    {
        var response = await _airportRepository.GetAirports(request.IATACode, cancellationToken);
        return response;
    }
}
