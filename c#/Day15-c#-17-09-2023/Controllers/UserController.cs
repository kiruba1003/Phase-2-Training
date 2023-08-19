using JWT_Auth.Models;
using JWT_Auth.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUser _user;
        public IToken _tokenGenerator;

        public UserController(IUser user, IToken tokenGenerator)
        {
            _user = user;
            _tokenGenerator= tokenGenerator;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetUserByUsername(string username)
        {
            try
            {
                var user = await _user.GetUserByUsername(username);
                var token = _tokenGenerator.GenerateToken(user.UserName, user.Role);
                return Ok(token);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(string username, User user)
        {
            try
            {
                var users = await _user.UpdateUser(username, user);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult<List<User>>> DeleteUser(string username)
        {
            try
            {
                var users = await _user.DeleteUser(username);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            var users = await _user.AddUser(user);
            return Ok(users);
        }

    }

}
