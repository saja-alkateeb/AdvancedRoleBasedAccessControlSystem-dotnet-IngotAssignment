using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoleBasedAccessControl.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RoleBasedAccessControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("profile")]
        [Authorize(Policy = "User")]
        public async Task<IActionResult> GetProfile()
        {
            var username = User.FindFirst(ClaimTypes.Name)?.Value;
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Username == username);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.Users
                                      .Where(u => u.Role == "User" || u.Role == "Admin")
                                      .ToListAsync();

            return Ok(users);
        }

        [HttpGet("all")]
        [Authorize(Policy = "SuperAdmin")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }
    }
}
