using LoginASPNetCore6.Models;

namespace LoginASPNetCore6.Services
{
    public interface AccountService
    {
        public Account Login(string username, string password);
    }
}
