using Microsoft.AspNetCore.Mvc;

namespace BuildingBug.API.Controllers
{
    [ApiController]  // This attribute enables some conventions for API controllers
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class ApiBaseController : ControllerBase
    {
        // You can add common functionality or properties shared among your API controllers here
        // For example, authentication checks, logging, etc.
    }
}
