using application.usecases;
using Microsoft.AspNetCore.Mvc;

namespace fiprobackdotnet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    // private readonly CreateUser _createUser;
    // private readonly ListUser _listUser;
    // public WeatherForecastController(CreateUser createUser, ListUser listUser)
    // {
    //     _createUser = createUser;
    //     _listUser = listUser;
    // }

    [HttpGet("{name}")]
    public string Get([FromServices] CreateUser _createUser, [FromRoute] string name)
    {
        return _createUser.execute(name);
    }

    [HttpGet]
    [Route("list")]
    public string List([FromServices] ListUser _listUser)
    {
        return _listUser.execute();
    }

}
