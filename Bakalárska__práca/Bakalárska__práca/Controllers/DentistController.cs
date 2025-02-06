using Bakalárska__práca.Shared.Model;
using Bakalárska__práca.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bakalárska__práca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DentistController : ControllerBase
    {
        private readonly IDentistService _dentistService;

        public DentistController(IDentistService dentistService)
        {
            _dentistService = dentistService;
        }

        [HttpGet("{specialization, region}")]
        public async Task<ActionResult<List<Dentist>>> GetFilteredDentists(string? specialization, string? region)
        {
            var result = await _dentistService.GetFilteredDentists(specialization, region);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dentist>> GetDentistById(int id)
        {
            var order = await _dentistService.GetDentistById(id);
            return Ok(order);
        }
    }
}
