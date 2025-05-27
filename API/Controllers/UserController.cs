using Application.UserCQ.Commands;
using Application.UserCQ.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace API.AddControllers;

[Route("[controller]")]
[ApiController]
public class CreateController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("create-user")]
    public async Task<ActionResult<UserInforViewModel>>CreateUser(CreateUserCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}