using HealthDiary.Application.Commands.User;
using HealthDiary.Application.Queries.User;
using HealthDiary.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthDiary.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : Controller
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route(nameof(AddUser))]
    [HttpPost]
    public async Task<ActionResult<User>> AddUser([FromBody] AddUserCommand command)
    {
        var user = await _mediator.Send(command);
        return Ok(user);
    }

    [Route(nameof(GetUserByUserName))]
    [HttpGet]
    public async Task<ActionResult<User>> GetUserByUserName(string userName)
    {
        var user = await _mediator.Send(new GetUserByUserNameQuery(userName));
        return Ok(user);
    }
}