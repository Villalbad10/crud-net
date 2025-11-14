using System.Threading.Tasks;
using crud_app.Models;

namespace crud_app.Services
{
    public interface UserService
    {
        dynamic listarUser();
        Task<User> guardarUser(User user);
    }
}
