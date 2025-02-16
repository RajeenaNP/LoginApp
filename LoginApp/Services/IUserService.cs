using LoginApp.Models;

namespace LoginApp.Services
{
    public interface IUserService
    {
       
        void AddUser(User user);

        List<User> GetUsers();

        User GetUserById(int id);
        void UpdateUser(User user);
    }
}
