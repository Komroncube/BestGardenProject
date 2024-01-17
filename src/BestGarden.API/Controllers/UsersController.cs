using BestGarden.Application.DTOs.Users;
using BestGarden.Application.UseCases.Users.Commands.CreateUser;
using BestGarden.Application.UseCases.Users.Commands.DeleteUser;
using BestGarden.Application.UseCases.Users.Commands.UpdateUser;
using BestGarden.Application.UseCases.Users.Queries.GetUserDetail;
using BestGarden.Application.UseCases.Users.Queries.GetUserList;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BestGarden.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<UsersController>
    [HttpGet]
    public async ValueTask<IActionResult> Get()
    {
        IReadOnlyList<User> users = await _mediator.Send(new GetUserListQuery());
        return Ok(users);
    }

    // GET api/<UsersController>/5
    [HttpGet("{id}")]
    public async ValueTask<UserDTO> Get(int id)
    {
        return await _mediator.Send(new GetUserByIdQuery { Id = id });
    }

    // POST api/<UsersController>
    [HttpPost]
    public async ValueTask<User> Post([FromForm] UserDTO userDto)
    {
        return await _mediator.Send(new CreateUserCommand { UserDto = userDto });
    }

    // PUT api/<UsersController>/5
    [HttpPut("{id}")]
    public async ValueTask<User> Put(int id, [FromBody] UserDTO userDto)
    {
        var updateUserCommand = new UpdateUserCommand { Id = id, UserDto = userDto };
        return await _mediator.Send(updateUserCommand);
    }

    // DELETE api/<UsersController>/5
    [HttpDelete("{id}")]
    public async ValueTask<bool> Delete(int id)
    {
        return await _mediator.Send(new DeleteUserCommand { Id = id });
    }
}
