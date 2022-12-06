using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ApplicationUser>> GetUsers()
        {
            return _context.ApplicationUsers.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<ApplicationUser> GetUserById(int id)
        {
            return _context.ApplicationUsers.Find(id);
        }
    }
}