using MediatR;

namespace Flights.Config.Domain.Airport.Queries;

public sealed record GetAirportByIATACodeRequest(string IATACode) 
    : IRequest<GetAirportByIATACodeResponse>;
