using Microsoft.AspNetCore.Mvc;

namespace AnimalShelterApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterAnimalsController : ControllerBase
    {
        private readonly ILogger<RegisterAnimalsController> _logger;

        public RegisterAnimalsController(ILogger<RegisterAnimalsController> logger)
        {
            _logger = logger;
        }
    }
}