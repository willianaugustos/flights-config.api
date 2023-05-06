using flights_config.Domain.Entities;

namespace flights_config.Domain.Repositories;

public interface IAirportsRepository
{
    Task<List<Airport>> GetAirports(CancellationToken cancellationToken);
    Task<Airport> GetAirports(string IataCode, CancellationToken cancellationToken);
}
