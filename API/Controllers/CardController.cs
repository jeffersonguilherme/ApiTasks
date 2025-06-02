using Application.CardCQ;
using Application.CardCQ.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller;

[Route("[controller]")]
[ApiController]
public class CreateController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("create-card")]
    public async Task<ActionResult<CarInfoViewModel>> CreateCard(CreateCardCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}