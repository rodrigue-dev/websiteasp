using finalMVC.Models;

namespace finalMVC.Repository
{
    public interface ILogin
    {
       
        Task<IEnumerable<User>> getuser();
        Task<User> AuthenticateUser(string email, string passcode);
    }
}
