using crud_app.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_app.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Ejemplo de DbSet
        public DbSet<User> Users { get; set; }
    }
}
