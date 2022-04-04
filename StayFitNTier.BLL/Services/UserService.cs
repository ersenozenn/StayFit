using StayFitNTier.DAL.Repositories;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.BLL.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        /// <summary>
        /// Check for correctness of Id.
        /// </summary>
        /// <param name="Id"></param>
        void CheckId(int Id)
        {
            if (Id <= 0) throw new Exception("Parameter value is not suitable!");
        }
        /// <summary>
        /// Gets user by given Id.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public User GetById(int userId)
        {
            CheckId(userId);
            return userRepository.GetById(userId);
        }
        /// <summary>
        /// Adds user to database.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool AddUser(User user)
        {
            return userRepository.Insert(user);
        }
        /// <summary>
        /// Deletes user by given userId.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(int userId)
        {
            CheckId(userId);
            User user = GetById(userId);
            return userRepository.DeleteforAdmin(user);
        }
        /// <summary>
        /// Gets all active users.
        /// </summary>
        /// <returns></returns>
        public List<User> GetActiveUsers()
        {
            return userRepository.GetActiveUsers();
        }
        /// <summary>
        /// Updates user row by given user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(User user)
        {            
            return userRepository.UpdateforAdmin(user);
        }
        /// <summary>
        /// Gets specific user by given mail.
        /// </summary>
        /// <param name="_mail"></param>
        /// <returns></returns>
        public User GetUserbyMail(string _mail)
        {
            return userRepository.GetUserbyMail(_mail);
        }
        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            return userRepository.List();
        }
        public bool UpdateforUser(User user)
        {
            return userRepository.UpdateforUser(user);
        }

    }
}
