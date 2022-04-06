using BasicSecurityASP.Model;

namespace BasicSecurityASP.Services
{
    public class UserService : IUserService
    {
        List<User> users = new List<User>()
        {
            new User() { Email = "buho@gmail.com", Password = "123" },
            new User() { Email = "buho2@gmail.com", Password = "456" }
        };


        public bool IsUser(string email, string pass) => users.Where(x => x.Email == email && x.Password == pass).Count() > 0;

    }
}
