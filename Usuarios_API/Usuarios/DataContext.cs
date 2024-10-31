using Microsoft.EntityFrameworkCore;
using Usuarios.Entities;

namespace Usuarios
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {
            
        }

        public DbSet<UserEntity> Users { get; set; }

    }
}
