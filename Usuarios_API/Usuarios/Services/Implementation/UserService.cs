using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Usuarios.Dto;
using Usuarios.Entities;
using Usuarios.Repositories;

namespace Usuarios.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ActionResult<bool>> CreateUser(UserDTO user)
        {
            return await _userRepository.CreateUser(user);
        }

        public async Task<ActionResult<bool>> DeleteUser(int id)
        {
            return await _userRepository.DeleteUser(id);
        }

        public async Task<ActionResult<List<UserEntity>>> GetUser()
        {
            return await _userRepository.GetUser();
        }

        public async Task<ActionResult<UserEntity>> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }

        public async Task<ActionResult<bool>> UpdateUser(UserDTO user, int id)
        {
            return await _userRepository.UpdateUser(user, id);
        }
    }
}
