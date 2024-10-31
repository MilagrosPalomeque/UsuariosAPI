using Microsoft.AspNetCore.Mvc;
using Usuarios.Dto;
using Usuarios.Entities;

namespace Usuarios.Services
{
    public interface IUserService
    {
        Task<ActionResult<bool>> UpdateUser(UserDTO user, int id);
        Task<ActionResult<bool>> DeleteUser(int id);
        Task<ActionResult<bool>> CreateUser(UserDTO user);
        Task<ActionResult<UserEntity>> GetUserById(int id);
        Task<ActionResult<List<UserEntity>>> GetUser();
    }
}
