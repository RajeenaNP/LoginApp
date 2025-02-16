using LoginApp.Models;

namespace LoginApp.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);  // Add this method to the interface
        List<User> GetAllUsers();

        User GetUserById(int id);  
        void UpdateUser(User user);

    }
}
