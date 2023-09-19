using LoginASPNetCore6.Models;

namespace LoginASPNetCore6.Services
{
    public class AccountServiceImpl : AccountService
    {
        private List<Account> account;

        public AccountServiceImpl()
        {
            account = new List<Account>()
            {
                new Account()
                {
                    UserName = "acc1",
                    Password = "123",
                    FullName = "Name 1"
                },
                new Account()
                {
                    UserName = "acc2",
                    Password = "123",
                    FullName = "Name 2"
                },
                new Account()
                {
                    UserName = "acc3",
                    Password = "123",
                    FullName = "Name 3"
                }
            };
        }

        public Account Login(string username, string password)
        {
            return account.SingleOrDefault(a => a.UserName == username && a.Password == password);
        }
    }
}
