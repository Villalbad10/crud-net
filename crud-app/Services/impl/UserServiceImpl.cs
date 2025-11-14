using System.Linq;
using System.Threading.Tasks;
using crud_app.Models;
using crud_app.data;
using crud_app.Services;
using Microsoft.EntityFrameworkCore;

namespace crud_app.Services.impl
{
    public class UserServiceImpl : UserService
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<User> dbSer;

        public UserServiceImpl(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSer = context.Set<User>();
        }

        public async Task<User> guardarUser(User user)
        {
            var newUser = dbSer.Add(user).Entity;
            await context.SaveChangesAsync();
            return newUser;
        }

        public dynamic listarUser()
        {
            return dbSer.ToList();
        }
    }
}
