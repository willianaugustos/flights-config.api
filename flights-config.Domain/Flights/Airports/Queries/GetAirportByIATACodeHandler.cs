using Flights.Config.Domain.Airport.Queries;
using MediatR;


namespace Flights.Config.Domain.Airport.Queries;

public class GetAirportByIATACodeHandler : IRequestHandler<GetAirportByIATACodeRequest, GetAirportByIATACodeResponse>
{
    public GetAirportByIATACodeHandler()
    {
    }

    public async Task<GetAirportByIATACodeResponse> Handle(GetAirportByIATACodeRequest request, CancellationToken cancellationToken)
    {
        var response = new GetAirportByIATACodeResponse() {Name = "Aeroporto Internacional de Guarulhos", IATACode = "GRU"};
        return response;
    }
}
