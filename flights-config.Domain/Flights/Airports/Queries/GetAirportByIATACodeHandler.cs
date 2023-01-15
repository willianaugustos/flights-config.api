using Flights.Config.Domain.Airport.Queries;
using MediatR;


namespace Flights.Config.Domain.Airport.Queries;

public class GetAirportByIATACodeHandler : IRequestHandler<GetAirportByIATACodeRequest, flights_config.Domain.Entities.Airport>
{
    public GetAirportByIATACodeHandler()
    {
    }

    // public async Task<GetAirportByIATACodeResponse> Handle(GetAirportByIATACodeRequest request, CancellationToken cancellationToken)
    // {
    //     var response = new GetAirportByIATACodeResponse() {Name = "Aeroporto Internacional de Guarulhos", IATACode = "GRU"};
    //     return response;
    // }

    public async Task<flights_config.Domain.Entities.Airport> Handle(GetAirportByIATACodeRequest request, CancellationToken cancellationToken)
    {
        var response = new flights_config.Domain.Entities.Airport() {Name = "Aeroporto Internacional de Guarulhos", IATACode = "GRU"};
        return response;
    }
}
