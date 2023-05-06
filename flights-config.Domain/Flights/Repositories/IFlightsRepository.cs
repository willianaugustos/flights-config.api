using flights_config.Domain.Entities;

namespace flights_config.Domain.Repositories;

public interface IFlightsRepository
{
    Task<List<Flight>> Search(string IATACodeFrom, string IATACodeTo, CancellationToken cancellationToken);
}