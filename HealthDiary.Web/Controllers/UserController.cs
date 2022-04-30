using Microsoft.AspNetCore.Mvc;

namespace HealthDiary.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : Controller
{
    public UserController()
    {
    }

    [Route("Apa")]
    [HttpGet]
    public async Task<ActionResult<string>> Get()
    {
        return "APA";
    }
}