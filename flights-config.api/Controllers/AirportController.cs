
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Flights.Config.Domain.Airport.Queries;

[ApiController]
[Route("[controller]")]

public class AirportController : ControllerBase
{
    private readonly ILogger<AirportController> _logger;
    private readonly ISender _sender;

    public AirportController(ILogger<AirportController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

[HttpGet]
    public async Task<ActionResult> Get(string IATACode)
    {
        var query = new GetAirportByIATACodeRequest(IATACode);
        var response = await _sender.Send(query);
        //return response.IsSuccess() ? Ok(response.Value) : NotFound(response.Error);
        return Ok(response);
    }
}