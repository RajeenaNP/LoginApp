using LoginApp.Models;
using LoginApp.Repositories;
using System.Security.Cryptography;
using System.Text;

namespace LoginApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

       

        public void AddUser(User user)
        {
          
            user.DateCreated = DateTime.Now;
            user.DateModified = DateTime.Now;

            _userRepository.AddUser(user);
        }


        public List<User> GetUsers()
        {
            return _userRepository.GetAllUsers();
        }


        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }
    }
}
