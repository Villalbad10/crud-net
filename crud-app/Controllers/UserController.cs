using crud_app.Models;
using crud_app.Services;
using Microsoft.AspNetCore.Mvc;

namespace crud_app.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {

        private readonly UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        [Route("list")]
        public dynamic listarUser() { 
            return new { message = "List of users" };
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<User>> CrearUsuario(User user)
        {
            var nuevoUsuario = await userService.guardarUser(user);
            return nuevoUsuario;
        }
    }
}
