using Microsoft.AspNetCore.Mvc;
using Usuarios.Dto;
using Usuarios.Entities;
using Usuarios.Services;

namespace Usuarios.Controllers
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
        [HttpGet]
        public async Task<ActionResult<List<UserEntity>>> GetUser()
        {
            return await _userService.GetUser();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserEntity>> GetUserById(int id)
        {
            return await _userService.GetUserById(id);
        }
        [HttpPost]

        public async Task<ActionResult<bool>> CreateUser(UserDTO user)
        {
            return await _userService.CreateUser(user);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteUser(int id)
        {
            return await _userService.DeleteUser(id);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> UpdateUser(UserDTO user, int id)
        {
            return await _userService.UpdateUser(user, id);
        }
    }
}
