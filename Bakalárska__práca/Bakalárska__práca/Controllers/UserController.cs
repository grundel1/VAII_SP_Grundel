using Bakalárska__práca.Shared.Model;
using Bakalárska__práca.Shared.Models;
using Bakalárska__práca.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bakalárska__práca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUser>> GetUserById(string id)
        {
            var result = await _userService.GetUserById(id);
            return Ok(result);
        }
    }
}