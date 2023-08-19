using JWT_Auth.Models;

namespace JWT_Auth.Services.Interface
{
    public interface IUser
    {
        Task<User>  GetUserByUsername(string username);

        Task<List<User>> AddUser(User user);

        Task<User> UpdateUser(string username, User user);

        Task<List<User>> DeleteUser(string username);

    }
}
