using Microsoft.AspNetCore.Mvc;
using ProductsApi.Modules.Dto;
using ProductsApi.Modules.Users.Interfaces;

namespace ProductsApi.Modules.Users.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> ListUsers(RetrieveUser retrieveUser)
        {
            var users = await _userRepository.ListUsers(retrieveUser);

            return Ok(users);
        }
    }
}
