using Reddit.Models;
using Reddit.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class UserService
    {
        public UserRepository userRepository;
        public UserService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void AddNewUser(User user)
        {
            userRepository.Create(user);
        }

        public void DeleteUser(User user)
        {
            userRepository.Delete(user);
        }

        public List<User> GetAllUsers()
        {
            return userRepository.Read();
        }

        public User GetUserById(int id)
        {
            return userRepository.GetElementById(id);
        }

        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }
    }
}
