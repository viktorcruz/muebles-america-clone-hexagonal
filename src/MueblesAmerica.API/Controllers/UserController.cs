using Microsoft.AspNetCore.Mvc;
using MueblesAmerica.Domain.Models;

namespace MueblesAmerica.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {

        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            try
            {
            }
            catch (Exception ex)
            {

            }
            return BadRequest(user);
        }
    }
}
