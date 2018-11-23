
using Microsoft.AspNetCore.Mvc;
using AdminTools.API.Models;
using System.Threading.Tasks;

namespace AdminTools.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        // public UserController()
        // {

        // }
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            User user = new User();
            user.Id = id;
            user.FirstName = "Adrian";
            user.LastName = "Miskell";
            user.Email = "adrianmi@avaya.com";
            return user;
        }

    }
}