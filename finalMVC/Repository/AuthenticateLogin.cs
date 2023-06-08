using finalMVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace finalMVC.Repository
{
    public class AuthenticateLogin:ILogin
    {
        private readonly SchoolCoreDBContext _context;

        public AuthenticateLogin(SchoolCoreDBContext context)
        {
            _context = context;
        }

        public async Task<User> AuthenticateUser(string email, string passcode)
        {
            var succeeded = await _context.UserLogin.FirstOrDefaultAsync(authUser => authUser.Email == email && authUser.Password == passcode);
            return succeeded;

        }

        public async Task<IEnumerable<User>> getuser()
        {
         
            return await _context.UserLogin.ToListAsync();
        }
    }
}
