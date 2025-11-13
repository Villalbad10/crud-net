using Microsoft.AspNetCore.Mvc;

namespace crud_app.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("list")]
        public dynamic listarUser() { 
            return new { message = "List of users" };
        }

        [HttpPost]
        [Route("save")]
        public dynamic guardarUser(User user) {
            
            user.
            return new { message = "User saved" };
        }
    }
}
