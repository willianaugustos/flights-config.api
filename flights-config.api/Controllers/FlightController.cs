
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Flights.Config.Domain.Airport.Queries;
using flights_config.Domain.Services;

[ApiController]
[Route("[controller]")]

public class FlightController : ControllerBase
{
    private readonly ILogger<AirportController> _logger;
    private readonly ISender _sender;

    public FlightController(ILogger<AirportController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

[HttpGet]
    public async Task<ActionResult> Search(string IATACodeOrigin, string IATACodeDestination)
    {
        var query = new SearchFlightsRequest(IATACodeOrigin, IATACodeDestination);
        var response = await _sender.Send(query);
        //return response.IsSuccess() ? Ok(response.Value) : NotFound(response.Error);
        return Ok(response);
    }
}