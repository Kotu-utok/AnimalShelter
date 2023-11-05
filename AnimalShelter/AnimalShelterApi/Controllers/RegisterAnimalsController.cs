using AnimalShelterApi.Model;
using AutoMapper;
using CDA.Model;
using CDA.Services.Implementation;
using Commun;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.ModelBinding;

namespace AnimalShelterApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterAnimalsController : ControllerBase
    {
        private readonly ILogger<RegisterAnimalsController> _logger;
        private IRegisterAnimalsServices _animalsServices;
        private IMapper _mapper;
        public RegisterAnimalsController(ILogger<RegisterAnimalsController> logger, IRegisterAnimalsServices animalsServices, IMapper mapper)
        {
            _logger = logger;
            _animalsServices = animalsServices;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult<AnimalModel> RegisterAnimal([FromBody] AnimalModel newAnimal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            OperationResult result = _animalsServices.RegisterAnimals(_mapper.Map<DomainAnimalModel>(newAnimal));

            if (result.IsSuccess)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}