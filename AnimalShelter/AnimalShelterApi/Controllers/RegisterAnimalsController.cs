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
        public RegisterAnimalsController(IRegisterAnimalsServices animalsServices, IMapper mapper)
        {
            //_logger = logger;
            _animalsServices = animalsServices;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<AnimalModel>> GetAnimal()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            FetchOperationResult<List<DomainAnimalModel>> result = await _animalsServices.GetAnimals();
            if (result.IsSuccess)
                return Ok(_mapper.Map<List<AnimalModel>>(result.Entity));
            else
                return BadRequest(result);
        }

        [HttpPost]
        public async Task<ActionResult<AnimalModel>> RegisterAnimals([FromBody] AnimalModel newAnimal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            OperationResult result = await _animalsServices.RegisterAnimal(_mapper.Map<DomainAnimalModel>(newAnimal));

            if (result.IsSuccess)
                return CreatedAtAction(nameof(GetAnimal), new { id = result.CreatedEntityId }, newAnimal);
            else
                return BadRequest(result);
        }
    }
}