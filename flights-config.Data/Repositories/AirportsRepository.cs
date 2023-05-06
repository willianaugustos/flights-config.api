using System.Linq;
using Flights.Data.Contexts;
using flights_config.Domain.Entities;
using flights_config.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace flights_config.Data.Repositories;

public class AirportsRepository : IAirportsRepository
{
    FlightsContext _dbContext;

    public AirportsRepository(FlightsContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Airport>> GetAirports(CancellationToken cancellationToken)
    {
        return await _dbContext.Set<Airport>()
        .ToListAsync();
    }

    public async Task<Airport> GetAirports(string IataCode, CancellationToken cancellationToken)
    {
        return await _dbContext.Set<Airport>()
        .FirstOrDefaultAsync(i=>i.IATACode.Equals(IataCode.ToUpper()), cancellationToken);
    }
}