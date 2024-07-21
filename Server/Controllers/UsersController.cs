using FinalProject_SapirTeper_OfirEinhoren.Server.Data;
using FinalProject_SapirTeper_OfirEinhoren.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_SapirTeper_OfirEinhoren.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }



        [HttpGet("LogeIn/{UName}/{UPass}")]
        public async Task<IActionResult> LoginUser(string UName, string UPass)
        {
            string SessionID = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(SessionID))
            {
                User userToReturn = await _context.Users.FirstOrDefaultAsync(u => u.UserName == UName.ToLower());
                if (userToReturn != null)
                {
                    HttpContext.Session.SetString("UserId", userToReturn.ID.ToString());
                    return Ok();
                }
                return BadRequest("User not found");
            }
            else
            {
                int userId = Convert.ToInt32(SessionID);
                User userToReturn = await _context.Users.FirstOrDefaultAsync(u => u.ID == userId && u.UserName == UName.ToLower() && u.Password == UPass.ToLower());
                if (userToReturn != null)
                {
                    return Ok();
                }
                return BadRequest("User not found");
            }
        }


       

    }
}
