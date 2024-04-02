using Microsoft.AspNetCore.Mvc;

namespace MobileFacilityFood.Controllers;

[ApiController]
[Produces("application/json")]
[Route("[controller]")]
public class BaseApiController : ControllerBase
{
}