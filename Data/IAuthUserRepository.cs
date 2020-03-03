using System.Threading.Tasks;
using GolfClub.API.Models;

namespace GolfClub.API.Data
{
    public interface IAuthUserRepository
    {
        Task<User> Register(User user, string password, string role);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}