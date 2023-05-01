using System.Linq;
using Flights.Data.Contexts;
using flights_config.Domain.Entities;
using flights_config.Domain.Repositories;
using Microsoft.EntityFrameworkCore;


namespace flights_config.Data.Repositories;

public class FlightsRepository : flights_config.Domain.Repositories.IFlightsRepository
{
    FlightsContext _dbContext;

    public FlightsRepository(FlightsContext dbContext)
    {
        _dbContext = dbContext;
    }
    // public async Task<List<Flight>> GetFlights(CancellationToken cancellationToken)
    // {
    //     return await _dbContext.Set<Flight>()
    //     .Include(t=>t.Segments)
    //     .ToListAsync();
    // }

    public async Task<List<Flight>> Search(string IATACodeFrom, string IATACodeTo, CancellationToken cancellationToken)
    {
        return await _dbContext.Set<Flight>()
        //.Include(t=>t.Segments)
        //.Where(i=>i.AirportO.Equals(IATACodeFrom.ToUpper()))
        .ToListAsync(cancellationToken);
    }
}