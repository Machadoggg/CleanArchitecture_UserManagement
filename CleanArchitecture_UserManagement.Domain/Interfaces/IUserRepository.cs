using CleanArchitecture_UserManagement.Domain.Entities;
using System.Threading.Tasks;

namespace CleanArchitecture_UserManagement.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsernameAsync(string username);
        Task AddUserAsync(User user);
    }
}
