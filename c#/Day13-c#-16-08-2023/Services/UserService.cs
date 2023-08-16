using JWT_Auth.Models;
using JWT_Auth.Services.Interface;
using Microsoft.EntityFrameworkCore;
using StudentDetails.GlobalExceptions;
using System.Linq;

namespace JWT_Auth.Services
{
    public class UserService : IUser
    {

        private PayodaStudentContext _context;

        public UserService(PayodaStudentContext context)
        {
            this._context = context;
        }
        
        public async Task<List<User>> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<List<User>> DeleteUser(string username)
        {
            var users = await _context.Users.FindAsync(username);
            if(users != null)
            {
                _context.Users.Remove(users);
               await _context.SaveChangesAsync();
                return await _context.Users.ToListAsync();
            }

            throw new Exception(StudentDetailsExceptions.ExceptionMessages[1]);
        }

        public async Task<User> GetUserByUsername(string username)
        {
            var users = await _context.Users.FindAsync(username);
            if(users!=null)
            {
                users = await _context.Users.FindAsync(username);
                return users;
            }
            return null;
        }

        public async Task<User> UpdateUser(string username, User user)
        {
            var users = await _context.Users.FindAsync(username);
            if(users != null)
            {
                users.Password = user.Password;
                users.Role = user.Role;
                users.Email = user.Email;
                _context.SaveChanges();
                users = await _context.Users.FindAsync(username);
                return users;
            }
            return null;
        }
    }
}
