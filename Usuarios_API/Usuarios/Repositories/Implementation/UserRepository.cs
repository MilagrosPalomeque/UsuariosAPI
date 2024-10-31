using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Usuarios.Dto;
using Usuarios.Entities;

namespace Usuarios.Repositories.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<bool>> CreateUser(UserDTO user)
        {
            UserEntity newUser = new UserEntity()
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };

            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<ActionResult<bool>> DeleteUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user is not null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<ActionResult<List<UserEntity>>> GetUser()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<ActionResult<UserEntity>> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ActionResult<bool>> UpdateUser(UserDTO user, int id)
        {
            var userexist = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user is not null)
            {
                _context.Entry(userexist).CurrentValues.SetValues(user);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
