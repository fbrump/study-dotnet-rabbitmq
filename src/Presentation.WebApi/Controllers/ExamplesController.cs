using Application.Commands;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class ExamplesController : ControllerBase
{
    private readonly ILogger<ExamplesController> _logger;
    private readonly IMediator _mediator;

    public ExamplesController(ILogger<ExamplesController> logger, IMediator mediator)
    {
        this._mediator = mediator;
        this._logger = logger;
    }

    [HttpGet(Name = "GetExamples")]
    public async Task<IEnumerable<string>> GetAsync()
    {
        await this._mediator.Send(new ExampleCommand());

        return await this._mediator.Send(new ExampleQuery(Guid.NewGuid()));
    }
}
